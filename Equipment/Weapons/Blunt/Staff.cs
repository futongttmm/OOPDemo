using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Equipment.Weapons.Blunt
{
    class Staff :Blunt
    {
        private const int DEFAULT_DAMAGE = 10;

        public Staff():this(DEFAULT_DAMAGE) { }

        public Staff(int damage) {
            base.Damage = damage;
        }
        public void Empower() { }

        public override void SpecialAbility()
        {
            this.Empower();
        }
    }
}
