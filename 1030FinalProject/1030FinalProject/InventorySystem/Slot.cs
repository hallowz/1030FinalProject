using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1030FinalProject.InventorySystem
{
    class Slot
    {
        private int _amount;
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        private Item _item;

        public Item Item
        {
            get { return _item; }
            set { _item = value; }
        }

        public Slot()
        {
            Amount = 0;
        }
    }
}
