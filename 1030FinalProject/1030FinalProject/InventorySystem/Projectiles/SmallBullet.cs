using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1030FinalProject.InventorySystem.Projectiles
{
    //SmallBullet inherits from Projectile
    class SmallBullet : Projectile
    {
        //Constructor for setting the direction of the bullet (not currently used)
        public SmallBullet(int x, int y)
        {
            //Setting all the variables associated with this item
            Type = ProjectileType.Bullet;
            ProjectileDamage = 3;
            ItemName = "Small Bullet";
            Gravity = 0.1f;
            Length = 0.1f;
            Width = 0.1f;
            XDirection = x;
            YDirection = y;
        }
        
        //Default constructor
        public SmallBullet()
        {
            //Setting all the variables associated with this item
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
