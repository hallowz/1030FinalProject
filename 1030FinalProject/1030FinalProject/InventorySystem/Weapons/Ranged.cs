using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1030FinalProject.InventorySystem
{
    //Ranged inherits from Weapon
    public class Ranged : Weapon
    {
        //Speed of projectile from this weapon
        private float _projectileSpeed;
        public float ProjectileSpeed
        {
            get { return _projectileSpeed; }
            set { _projectileSpeed = value; }
        }
        
        //Num of projectiles per shot
        private int _numOfProjectiles;
        public int NumOfProjectiles
        {
            get { return _numOfProjectiles; }
            set { _numOfProjectiles = value; }
        }

        //Size of clip before reloading
        private int _clipSize;
        public int ClipSize
        {
            get { return _clipSize; }
            set { _clipSize = value; }
        }

        //Amount of ammo that can be held other than in the clip
        private int _reserveAmmo;
        public int ReserveAmmo
        {
            get { return _reserveAmmo; }
            set { _reserveAmmo = value; }
        }

        //Projectile this weapon shoots
        private Projectile _projectile;
        public Projectile Projectile
        {
            get { return _projectile; }
            set { _projectile = value; }
        }

        //Function to get stats
        public override List<string> ToStrings()
        {
            List<string> s = new List<string>();
            s.Add("Rate of fire: " + RateOfFire);
            s.Add("Projectile Speed: " + ProjectileSpeed);
            s.Add("Projectile: " + Projectile.Type);
            s.Add("Clip Size: " + ClipSize);
            s.Add("Reserve Ammo: " + ReserveAmmo);
            s.Add("Num of Projectiles: " + NumOfProjectiles);
            return s;
        }


    }
}
