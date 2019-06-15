using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Equipment.Weapons.Sharp
{
    class Sword: Sharp
    {
        private const int DEFAULT_DAMAGE = 10;
        public Sword() :this(DEFAULT_DAMAGE){ }
        public Sword(int damage)
        {
            base.Damage = damage;
        }
        public void Bloodthirst() { }

        public override void SpecialAbility()
        {
            this.Bloodthirst();
        }
    }
}
