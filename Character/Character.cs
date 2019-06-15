using ConsoleApp1.Characters.Interface;
using ConsoleApp1.Enum;
using ConsoleApp1.Equipment.Armors;
using ConsoleApp1.Equipment.Weapons;
using System;

namespace ConsoleApp1.Characters
{
    public abstract class Character: Iattacking, Idefending
    {
        private Faction faction;
        private int healthPoints;
        private int level;
        private string name;
        private Weapons weapon;
        private Armors bodyArmor;

        private bool isAlive;
        private int score;

        public virtual int HealthPoints
        {
            set
            {
                if (value >= 0 && value <= 150)
                {
                    this.healthPoints = value;
                }
            }
            get
            {
                return this.healthPoints;
            }
        }

        public virtual void Test()
        {

        }

        public int Level
        {
            set
            {
                if (value > 0)
                {
                    level = value;
                }
            }
            get
            {
                return level;
            }
        }

        public string Name
        {
            set
            {
                if (value != null)
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }

        public Faction Faction
        {
            set
            {
                faction = value;
            }
            get
            {
                return faction;
            }
        }

        public Armors BodyArmor
        {
            set
            {
                if (value.ArmorPoints > 0)
                {
                    bodyArmor = value;
                }
            }
            get
            {
                return bodyArmor;
            }
        }
        public Weapons Weapon
        {
            set
            {
                if (value.Damage > 0)
                {
                    weapon = value;
                }
            }
            get
            {
                return weapon;
            }
        }
        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }
            set
            {
                this.isAlive = value;
            }
        }
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }

        public abstract int Attacking();
        public abstract int Defending();
        public abstract int SpecialAttacking();
        public void TakeDamage(int damage, string attackerName)
        {
            if (this.Defending() < damage)
            {
                this.HealthPoints = this.HealthPoints - damage + this.Defending();

                if (this.HealthPoints <= 0)
                {
                    this.IsAlive = false;
                }
            }
            else
            {
                Console.WriteLine("Haha! Your damage was not enough to harm me!");
            }

            if (!this.IsAlive)
            {
                Console.WriteLine($"{this.name} received {damage} damage from {attackerName}, and is now dead!");
                
            }
            else
            {
                Console.WriteLine($"{this.name} received {damage} damage from {attackerName}, and now has {this.healthPoints} healthpoints!");
              
            }
        }

        public void WonBattle()
        {
            this.Score++;
            if(this.Score % 10 == 0)
            {
                this.Level++;
            }
        }
    }
}
