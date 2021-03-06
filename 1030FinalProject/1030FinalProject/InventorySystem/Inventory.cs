using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1030FinalProject.InventorySystem
{
    class Inventory
    {
        //Declaring variables

        //Size of the inventory
        private int _size;
        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        //List of slots
        private List<Slot> _slots;
        public List<Slot> Slots
        {
            get { return _slots; }
            set { _slots = value; }
        }

        //Weapon slot
        private Slot _weaponSlot;
        public Slot WeaponSlot
        {
            get { return _weaponSlot; }
            set { _weaponSlot = value; }
        }

        //Create inventory
        public Inventory(int Size)
        {
            this.Size = Size;
            WeaponSlot = new Slot();
            Slots = new List<Slot>();

            //Populate list of slots with empty slots
            for(int i = 0; i < Size; i++)
            {
                Slots.Add(new Slot());
            }
        }

        //Add item to inventory. Sets the item of an empty slot or adds to a slot with the same item, whichever comes first.
        public bool AddItem(Item item)
        {
            foreach(Slot s in Slots)
            {
                if(s.Item != null)
                {
                    if (s.Item.ItemName == item.ItemName)
                    {
                        s.Amount++;
                        return true;
                    }
                }
                else
                {
                    s.Item = item;
                    s.Amount++;
                    return true;
                }
            }
            return false;
        }

        //Remove single item from selected slot. If slot amount is only 1, slot is cleared
        public void RemoveItem(int slotIndex)
        {
            Slot s = Slots[slotIndex];
            if (s != null)
            {
                if(s.Amount > 1)
                {
                    s.Amount--;
                }
                else
                {
                    Slots[slotIndex] = new Slot();
                }
            }
        }

        //Clear selected slot, regardless of amount
        public void RemoveAllItem(int slotIndex)
        {
            Slots[slotIndex] = new Slot();
        }

        //Equip weapon to weapon slot. Returns true if successful, returns false otherwise
        public bool EquipWeapon(int slotIndex)
        {
            if (Slots[slotIndex].Item != null)
            {
                if (Slots[slotIndex].Item.GetType().IsSubclassOf(typeof(Weapon)))
                {
                    if (UnEquipWeapon())
                    {
                        if (Slots[slotIndex].Amount > 1)
                        {
                            Slots[slotIndex].Amount--;
                            WeaponSlot = new Slot();
                            WeaponSlot.Item = Slots[slotIndex].Item;
                            WeaponSlot.Amount = 1;
                            return true;
                        }
                        else if (Slots[slotIndex].Amount == 1)
                        {
                            WeaponSlot = new Slot();
                            WeaponSlot.Item = Slots[slotIndex].Item;
                            System.Diagnostics.Debug.WriteLine("Weapon set to " + Slots[slotIndex].Item.ItemName);
                            Slots[slotIndex] = new Slot();
                            return true;
                        }
                    }
                }
            }
            
            return false;
        }

        //Unequip currently equipped weapon. Returns false if no room in inventory to put equipped weapon
        public bool UnEquipWeapon()
        {
            if(WeaponSlot.Item != null)
            {
                if (AddItem(WeaponSlot.Item))
                {
                    WeaponSlot = new Slot();
                    return true;
                }
                else
                {
                    //Weapon not unequipped because no room in inventory
                    return false;
                }
            }
            return true;
        }

    }
}
