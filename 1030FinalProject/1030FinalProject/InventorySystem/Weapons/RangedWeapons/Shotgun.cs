using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1030FinalProject.InventorySystem.Weapons.RangedWeapons
{
    //Shotgun inherits from Ranged
    class Shotgun : Ranged
    {
        public Shotgun()
        {
            //Setting all the variables associated with this item
            ItemName = "Shotgun";
            Projectile = new Projectiles.Shell();
            ProjectileSpeed = 10;
            NumOfProjectiles = 10;
            ClipSize = 6;
            ReserveAmmo = 60;
        }
    }
}
