using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1030FinalProject.InventorySystem
{
    public class Ranged : Weapon
    {
        private float _projectileSpeed;
        public float ProjectileSpeed
        {
            get { return _projectileSpeed; }
            set { _projectileSpeed = value; }
        }
        
        private int _numOfProjectiles;
        public int NumOfProjectiles
        {
            get { return _numOfProjectiles; }
            set { _numOfProjectiles = value; }
        }
        private int _clipSize;
        public int ClipSize
        {
            get { return _clipSize; }
            set { _clipSize = value; }
        }
        private int _reserveAmmo;
        public int ReserveAmmo
        {
            get { return _reserveAmmo; }
            set { _reserveAmmo = value; }
        }
        private Projectile _projectile;
        public Projectile Projectile
        {
            get { return _projectile; }
            set { _projectile = value; }
        }
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
