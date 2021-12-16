using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1030FinalProject.InventorySystem.Projectiles
{
    class SmallBullet : Projectile
    {
        public SmallBullet(int x, int y)
        {
            Type = ProjectileType.Bullet;
            ProjectileDamage = 3;
            ItemName = "Small Bullet";
            Gravity = 0.1f;
            Length = 0.1f;
            Width = 0.1f;
            XDirection = x;
            YDirection = y;
        }
        
        public SmallBullet()
        {
            Type = ProjectileType.Bullet;
            ProjectileDamage = 3;
            ItemName = "Small Bullet";
            Gravity = 0.1f;
            Length = 0.1f;
            Width = 0.1f;
            XDirection = 0;
            YDirection = 0;
        }
    }
}
