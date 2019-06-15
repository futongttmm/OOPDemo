
using ConsoleApp1.Equipment.Armors.Heavy;
using ConsoleApp1.Equipment.Weapons.Blunt;
using ConsoleApp1.Enum;
using ConsoleApp1.Characters.Melee;
using System;

namespace ConsoleApp1.Characters
{
    class Knight: Melees
    {
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();

        public Knight():this(Consts.Knight.NAME, Consts.Knight.LEVEL) { }
        public Knight(string name, int level):this(Consts.Knight.NAME, Consts.Knight.LEVEL, Consts.Knight.HEALTH_POINTS) { }
        public Knight(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            this.HealthPoints = healthPoints;
            base.Faction = Faction.Spellcaster;
            base.AbilityPoints = Consts.Knight.ABILITY_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.IsAlive = true;
            base.Score = 0;
        }

        public override int HealthPoints
        {
            set
            {
                if (value >= 0 && value <= 10)
                {
                    base.HealthPoints = value;
                }
            }
            get
            {
                return base.HealthPoints;
            }
        }


        public override int Attacking()
        {
            return this.HolyBlow();
        }

        public override int Defending()
        {
            return this.RighteousWings();
        }

        public int HolyBlow() {
            return base.Weapon.Damage + 10;
            //Console.WriteLine("Knight's attack");
        }
        public int PurifySoul() {
            return base.Weapon.Damage + 20;
        }
        public int RighteousWings() {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int SpecialAttacking()
        {
            return this.PurifySoul();
        }
    }
}
