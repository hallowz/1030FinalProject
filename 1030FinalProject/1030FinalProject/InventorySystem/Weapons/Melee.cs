using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1030FinalProject.InventorySystem.Weapons
{
    //Melee inherits 
    class Melee : Weapon
    {
        private float  _length;
        public float  Length
        {
            get { return _length; }
            set { _length = value; }
        }
        private float _width;
        public float Width
        {
            get { return _width; }
            set { _width = value; }
        }
        private float _damagePerHit;
        public float DamagePerHit
        {
            get { return _damagePerHit; }
            set { _damagePerHit = value; }
        }

        public override List<string> ToStrings()
        {
            List<string> s = new List<string>();
            s.Add("Rate of fire: " + RateOfFire);
            s.Add("Damage per hit: " + DamagePerHit);
            s.Add("Length: " + Length);
            s.Add("Width: " + Width);
            return s;
        }
        public Melee()
        {

        }
    }
}
