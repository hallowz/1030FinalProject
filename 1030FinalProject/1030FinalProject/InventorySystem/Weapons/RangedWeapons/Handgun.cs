using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1030FinalProject.InventorySystem.Weapons;

namespace _1030FinalProject.InventorySystem.Weapons.RangedWeapons
{
    public class Handgun : Ranged
    {
        public Handgun()
        {
            ItemName = "Handgun";
            Projectile = new Projectiles.SmallBullet();
            ProjectileSpeed = 10;
            NumOfProjectiles = 1;
            ClipSize = 12;
            ReserveAmmo = 200;
        }
    }
}
