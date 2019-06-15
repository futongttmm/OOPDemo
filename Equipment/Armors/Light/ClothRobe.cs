using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Equipment.Armors.Light
{
    class ClothRobe : Light
    {
        private const int DEFAULT_ARMOR_POINTS = 10;
        public ClothRobe():this(DEFAULT_ARMOR_POINTS) { }
        public ClothRobe(int armor)
        {
            base.ArmorPoints = armor;
        }
        
    }
}
