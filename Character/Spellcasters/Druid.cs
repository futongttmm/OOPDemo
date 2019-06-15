using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Equipment.Armors.Light;
using ConsoleApp1.Equipment.Weapons.Blunt;
using ConsoleApp1.Enum;

namespace ConsoleApp1.Characters.Spellcasters
{
    class Druid:Spellcasters
    {

        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public Druid() : this(Consts.Druid.NAME, Consts.Druid.LEVEL) { }
        public Druid(string name, int level) : this(Consts.Druid.NAME, Consts.Druid.LEVEL, Consts.Druid.HEALTH_POINTS) { }
        public Druid(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            this.HealthPoints = healthPoints;
            base.Faction = Faction.Spellcaster;
            base.AbilityPoints = Consts.Druid.ABILITY_POINTS;
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

        public int Moonfire() {
            return base.Weapon.Damage + 10;
        }
        public int Starburst() {
            return base.Weapon.Damage + 20;
        }
        public int OneWithTheNature() {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attacking()
        {
            return this.Moonfire();
        }

        public override int Defending()
        {
            return this.OneWithTheNature();
        }

        public override int SpecialAttacking()
        {
            return this.Starburst();
        }
    }
}
