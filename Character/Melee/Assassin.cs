using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Equipment.Weapons.Sharp;
using ConsoleApp1.Equipment.Armors.Leather;
using ConsoleApp1.Enum;


namespace ConsoleApp1.Characters.Melee
{
    class Assassin: Melees
    {
        
        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();
        

        public Assassin():this(Consts.Assassin.NAME, Consts.Assassin.LEVEL) { }
        public Assassin(string name, int level) :this(Consts.Assassin.NAME, Consts.Assassin.LEVEL, Consts.Assassin.HEALTH_POINTS) { }
        public Assassin(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            this.HealthPoints = healthPoints;
            base.Faction = Faction.Spellcaster;
            base.AbilityPoints = Consts.Assassin.ABILITY_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.IsAlive = true;
            base.Score = 0;
        }

        public override int HealthPoints
        {
            set
            {
                if(value >= 0 && value <= 120)
                {
                    base.HealthPoints = value;
                }
            }
            get
            {
                return base.HealthPoints;
            }
        }

        public int Raze(int a)
        {
            return 0;
        }

        public int Raze() {
            return base.Weapon.Damage + 10;
            //Console.WriteLine("Assassin's attack");
        }
        public int BleedToDeath() {
            return base.Weapon.Damage + 20;
            //Console.WriteLine("Assassin's apecial attack");
        }
        public int Survial() {
            return base.BodyArmor.ArmorPoints + 5;
            //Console.WriteLine("Assassin's defend");
        }

        public override int Attacking()
        {
            return this.Raze();
        }

        public override int Defending()
        {
            return this.Survial();
        }

        public override int SpecialAttacking()
        {
            return this.BleedToDeath();
        }

        public override void Test()
        {
            base.Test();
        }
    }
}
