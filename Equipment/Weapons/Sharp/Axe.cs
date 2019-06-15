using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Equipment.Weapons.Sharp
{
    class Axe: Sharp
    {
        private const int DEFAULT_DAMAGE = 10;
        public Axe():this(DEFAULT_DAMAGE) { }
        public Axe(int damage)
        {
            base.Damage = damage;
        }
        public void HackNSlask() { }
        public override void SpecialAbility()
        {
            this.HackNSlask();
        }
    }
}
