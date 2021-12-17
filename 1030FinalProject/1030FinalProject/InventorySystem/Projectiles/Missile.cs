using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1030FinalProject.InventorySystem.Projectiles
{
    //Missile inherits from Projectile
    class Missile : Projectile
    {
        public Missile()
        {

            //Setting all the variables associated with this item
            Type = ProjectileType.Explosive;
            ProjectileDamage = 40;
            ItemName = "Missile";
            Gravity = 0.6f;
            Length = 0.6f;
            Width = 0.2f;
            XDirection = 0;
            YDirection = 0;
        }
    }
}
