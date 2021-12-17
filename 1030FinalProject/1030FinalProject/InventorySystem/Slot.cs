using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1030FinalProject.InventorySystem
{
    class Slot
    {
        //Amount of items held in this slot
        private int _amount;
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        //The item held in this slot
        private Item _item;
        public Item Item
        {
            get { return _item; }
            set { _item = value; }
        }

        //When created, Item = null and Amount = 0 -> empty
        public Slot()
        {
            Amount = 0;
        }
    }
}
