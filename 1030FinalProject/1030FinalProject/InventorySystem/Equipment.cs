using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1030FinalProject.InventorySystem
{
    public enum EquipmentType { Head, Chest, Legs, Feet, Hands, Shoulders }
    class Equipment : Item
    {
        private EquipmentType _type;
        public EquipmentType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private float _defenseBonus;
        public float DefenseBonus
        {
            get { return _defenseBonus; }
            set { _defenseBonus = value; }
        }

        public override List<string> ToStrings()
        {
            List<string> s = new List<string>();
            s.Add("Type: " + Type);
            s.Add("Defense Bonus: " + DefenseBonus);
            return s;
        }
        public Equipment()
        {

        }
    }
}
