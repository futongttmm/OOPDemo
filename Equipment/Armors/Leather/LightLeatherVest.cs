using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Equipment.Armors.Leather
{
    class LightLeatherVest: Leather
    {
        private const int DEFAULT_ARMOR_POINTS = 10;
        public LightLeatherVest():this(DEFAULT_ARMOR_POINTS) { }
        public LightLeatherVest(int armor)
        {
            base.ArmorPoints = armor;
        }
    }
}
