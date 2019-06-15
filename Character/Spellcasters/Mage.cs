using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Equipment.Armors.Light;
using ConsoleApp1.Equipment.Weapons.Sharp;
using ConsoleApp1.Enum;

namespace ConsoleApp1.Characters.Spellcasters
{
    class Mage: Spellcasters
    {

        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        public Mage() : this(Consts.Mage.NAME, Consts.Mage.LEVEL) { }
        public Mage(string name, int level) : this(Consts.Mage.NAME, Consts.Mage.LEVEL, Consts.Mage.HEALTH_POINTS) { }
        public Mage(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Faction.Spellcaster;
            base.AbilityPoints = Consts.Mage.ABILITY_POINTS;
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


        public int ArcaneWrath() {
            return base.Weapon.Damage + 20;
        }

        public override int Attacking()
        {
            return this.Firewall();
        }

        public override int Defending()
        {
            return this.Meditation();
        }

        public int Firewall() {
            return base.Weapon.Damage + 10;
        }
        public int Meditation() {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int SpecialAttacking()
        {
            return this.ArcaneWrath();
        }
    }
}
