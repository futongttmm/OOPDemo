using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Characters.Melee
{
    public abstract class Melees: Character
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

        public override void Test() {
            base.Test();
        }
    }
}
