using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Equipment.Armors.Leather;
using ConsoleApp1.Equipment.Weapons.Sharp;
using ConsoleApp1.Enum;

namespace ConsoleApp1.Characters.Spellcasters
{
    class Necromancer:Spellcasters
    { 
        private readonly LightLeatherVest DEFAULT_BODY_ARMOR= new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON= new Sword();

        public Necromancer() : this(Consts.Necromancer.NAME, Consts.Necromancer.LEVEL) { }
        public Necromancer(string name, int level) : this(Consts.Necromancer.NAME, Consts.Necromancer.LEVEL, Consts.Necromancer.HEALTH_POINTS) { }
        public Necromancer(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            this.HealthPoints = healthPoints;
            base.Faction = Faction.Spellcaster;
            base.AbilityPoints = Consts.Necromancer.ABILITY_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.IsAlive = true;
            base.Score = 0;
        }

        public override int HealthPoints {
            get => base.HealthPoints;
            set
            {
                if(value >= 0 && value <= 120)
                {
                    base.HealthPoints = value;
                }
            }
        }

        public int ShadowRage() {
            return base.Weapon.Damage + 10;
        }
        public int VampireTouch() {
            return base.Weapon.Damage + 20;
        }
        public int BoneShield() {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attacking()
        {
            return this.ShadowRage();
        }

        public override int Defending()
        {
            return this.BoneShield();
        }

        public override int SpecialAttacking()
        {
            return this.VampireTouch();
        }
    }
}
