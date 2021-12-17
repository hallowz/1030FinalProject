using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1030FinalProject.InventorySystem
{
    //Weapon inherits from item
    public class Weapon : Item
    {
        //Rate of fire this weapon
        private float _rateOfFire;
        public float RateOfFire
        {
            get { return _rateOfFire; }
            set { _rateOfFire = value; }
        }

        //Function to get stats
        public override List<string> ToStrings()
        {
            List<string> s = new List<string>();
            s.Add("Rate of fire: " + RateOfFire);
            return s;
        }
    }
}
