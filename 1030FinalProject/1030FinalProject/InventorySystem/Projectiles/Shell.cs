using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1030FinalProject.InventorySystem.Projectiles
{
    //Shell inherits from Projectile
    class Shell : Projectile
    {
        public Shell()
        {
            //Setting all the variables associated with this item
            Type = ProjectileType.Bullet;
            ProjectileDamage = 10;
            ItemName = "Shell";
            Gravity = 0.1f;
            Length = 0.1f;
            Width = 0.1f;
            XDirection = 0;
            YDirection = 0;
        }
    }
}
