using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1030FinalProject.InventorySystem
{
    public class Weapon : Item
    {
        private float _rateOfFire;
        public float RateOfFire
        {
            get { return _rateOfFire; }
            set { _rateOfFire = value; }
        }
        public override List<string> ToStrings()
        {
            List<string> s = new List<string>();
            s.Add("Rate of fire: " + RateOfFire);
            return s;
        }
    }
}
