using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Characters.Spellcasters
{
    public abstract class Spellcasters: Character
    {
        private int abilityPoints;
        public int AbilityPoints
        {
            set
            {
                if (value >= 0 && value <= 10)
                {
                    abilityPoints = value;
                }
            }
            get
            {
                return abilityPoints;
            }
        }
    }
}
