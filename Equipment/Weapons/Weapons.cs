using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Equipment.Weapons
{
    public abstract class Weapons:Equipments
    {
        private int damage;

        public int Damage
        {
            set
            {
                if (value > 0)
                {
                    damage = value;
                }
            }
            get
            {
                return damage;
            }
        }
        public abstract void SpecialAbility();
    }
}
