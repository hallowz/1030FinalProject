using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1030FinalProject.InventorySystem.Weapons.MeleeWeapons
{
    class Sword : Melee
    {
        public Sword()
        {
            ItemName = "Sword";
            RateOfFire = 1;
            Length = 2;
            Width = 0.2f;
            DamagePerHit = 35;
        }
    }
}
