using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Equipment.Armors.Heavy
{
    class Chainlink: Heavy
    {
        private const int DEFAULT_ARMOR_POINTS = 10;
        public Chainlink():this(DEFAULT_ARMOR_POINTS) { }
        public Chainlink(int armor)
        {
            base.ArmorPoints = armor;
        }
    }
}
