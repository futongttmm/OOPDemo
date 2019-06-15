using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Equipment.Armors
{
    public abstract class Armors : Equipments
    {
        private int armorPoints;

        public int ArmorPoints
        {
            set
            {
                if (value > 0)
                {
                    armorPoints = value;
                }
            }
            get
            {
                return armorPoints;
            }
        }
    }
}
