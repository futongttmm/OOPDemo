using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Equipment.Weapons.Blunt
{
    class Hammer: Blunt
    {
        private const int DEFAULT_DAMAGE = 10;
        public Hammer():this(DEFAULT_DAMAGE) { }
        public Hammer(int damage)
        {
            base.Damage = damage;
        }

        public override void SpecialAbility()
        {
            this.Stun();
        }

        public void Stun() { }

    }
}
