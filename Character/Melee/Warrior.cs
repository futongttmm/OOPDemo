using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Equipment.Armors.Heavy;
using ConsoleApp1.Equipment.Weapons.Sharp;
using ConsoleApp1.Enum;
using ConsoleApp1.Characters.Melee;
using ConsoleApp1;

namespace Characters
{
    class Warrior : Melees
    {
        

        //We cannot extract those two lines to consts.cs, because each class has different weapon and armor
        //Plus, static class cannot have object (it cannot instantiate objects)
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();

        public Warrior() : this(Consts.Warrior.NAME, Consts.Warrior.LEVEL) { }
        public Warrior(string name, int level) : this(Consts.Warrior.NAME, Consts.Warrior.LEVEL, Consts.Warrior.HEALTH_POINTS) { }
        public Warrior(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            this.HealthPoints = healthPoints;
            base.Faction = Faction.Spellcaster;
            base.AbilityPoints = Consts.Warrior.ABILITY_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.IsAlive = true;
            base.Score = 0;
        }

        public override int HealthPoints
        {
            set
            {
                if (value >= 0 && value <= 120)
                {
                    base.HealthPoints = value;
                }
            }
            get
            {
                return base.HealthPoints;
            }
        }

        public int Strike() {
            //Console.WriteLine("Warrior's attack");
            return base.Weapon.Damage + 10;
        }
        public int Execute() {
            return base.Weapon.Damage + 20;
        }
        public int SkinHarden() {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attacking()
        {
            return this.Strike();
        }

        public override int Defending()
        {
            return this.SkinHarden();
        }

        public override int SpecialAttacking()
        {
            return this.Execute();
        }
    }

   
}
