using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1030FinalProject.InventorySystem
{
    public abstract class Item
    {

        //Name of the item
        private string _itemName;
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        //Function to get all stats associated with the item in a displayable format
        public abstract List<string> ToStrings();

        public Item()
        {

        }
    }
}
