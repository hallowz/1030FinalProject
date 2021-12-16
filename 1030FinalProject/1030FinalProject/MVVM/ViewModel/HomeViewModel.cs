using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using _1030FinalProject.Core;
using _1030FinalProject.InventorySystem;
using _1030FinalProject.InventorySystem.Projectiles;
using _1030FinalProject.InventorySystem.Weapons.MeleeWeapons;
using _1030FinalProject.InventorySystem.Weapons.RangedWeapons;

namespace _1030FinalProject.MVVM.ViewModel
{
    class HomeViewModel : ObservableObject
    {
        public RelayCommand AddHandgunButton { get; set; }
        public RelayCommand AddSmallBulletButton { get; set; }
        public RelayCommand AddSwordButton { get; set; }
        public RelayCommand AddShotgunButton { get; set; }
        public RelayCommand AddShellButton { get; set; }
        public RelayCommand AddMissileButton { get; set; }
        public RelayCommand EquipButton { get; set; }
        public RelayCommand UnequipButton { get; set; }
        public RelayCommand InventoryButton { get; set; }
        public RelayCommand RemoveItemButton { get; set; }
        public RelayCommand RemoveAllItemButton { get; set; }

        private Inventory _inventory;
        public Inventory Inventory
        {
            get { return _inventory; }
            set
            {
                _inventory = value;
                int i = 0;
                foreach (Slot s in Inventory.Slots)
                {
                    if (s.Item != null)
                    {
                        Slots[i] = "" + s.Item.ItemName + "\n" + s.Amount;
                    }
                    else
                    {
                        Slots[i] = "Nothing";
                    }
                    i++;
                }
                if(Inventory.WeaponSlot.Item != null)
                {
                    Slots[5] = "" + Inventory.WeaponSlot.Item.ItemName;
                }
                else
                {
                    Slots[5] = "Nothing";
                }
                OnPropertyChanged("Slots");
                OnPropertyChanged("Inventory");
            }
        }

        private int _selectedSlot;
        public int SelectedSlot
        {
            get { return _selectedSlot; }
            set
            {
                _selectedSlot = value;
                if(Inventory.Slots[value] != null)
                {
                    SlotSelection = Inventory.Slots[value];
                    if (Inventory.Slots[value].Item != null)
                        Stats = Inventory.Slots[value].Item.ToStrings();
                    else
                        Stats = new List<string>();
                }
                
                OnPropertyChanged("SelectedSlot");
            }
        }

        private Slot _slotSelection;
        public Slot SlotSelection
        {
            get { return _slotSelection; }
            set
            {
                _slotSelection = value;
                OnPropertyChanged("SlotSelection");
            }
        }
        private List<string> _stats;
        public List<string> Stats
        {
            get { return _stats; }
            set
            {
                _stats = value;
                OnPropertyChanged("Stats");
            }
        }
        private List<string> _slots; 
        public List<string> Slots
        {
            get { return _slots; }
            set
            {
                _slots = value;
                OnPropertyChanged("Slots");
            }
        }

        public HomeViewModel()
        {
            Slots = new List<string> { "", "", "", "", "", "" };
            Stats = new List<string>();
            Inventory = new Inventory(5);
            SelectedSlot = 0;
            AddHandgunButton = new RelayCommand(o =>
            {
                if (!Inventory.AddItem(new Handgun()))
                {
                    System.Diagnostics.Debug.WriteLine("Handgun could not be added to inventory");
                    MessageBox.Show("Handgun could not be added to inventory");
                }
                RefreshInventory();
            });
            AddShotgunButton = new RelayCommand(o =>
            {
                if (!Inventory.AddItem(new Shotgun()))
                {
                    System.Diagnostics.Debug.WriteLine("Shotgun could not be added to inventory");
                    MessageBox.Show("Shotgun could not be added to inventory");
                }
                RefreshInventory();
            });
            AddSmallBulletButton = new RelayCommand(o =>
            {
                if (!Inventory.AddItem(new SmallBullet()))
                {
                    System.Diagnostics.Debug.WriteLine("Small bullet could not be added to inventory");
                    MessageBox.Show("Small bullet could not be added to inventory");
                }
                RefreshInventory();
            });
            AddShellButton = new RelayCommand(o =>
            {
                if (!Inventory.AddItem(new Shell()))
                {
                    System.Diagnostics.Debug.WriteLine("Shell could not be added to inventory");
                    MessageBox.Show("Shell could not be added to inventory");
                }
                RefreshInventory();
            });
            AddMissileButton = new RelayCommand(o =>
            {
                if (!Inventory.AddItem(new Missile()))
                {
                    System.Diagnostics.Debug.WriteLine("Missile could not be added to inventory");
                    MessageBox.Show("Missile could not be added to inventory");
                }
                RefreshInventory();
            });

            AddSwordButton = new RelayCommand(o =>
            {
                if (!Inventory.AddItem(new Sword()))
                {
                    System.Diagnostics.Debug.WriteLine("Sword could not be added to inventory");
                    MessageBox.Show("Sword could not be added to inventory");
                }
                RefreshInventory();
            });

            EquipButton = new RelayCommand(o =>
            {
                RefreshInventory();
                if (!Inventory.EquipWeapon(SelectedSlot))
                {
                    System.Diagnostics.Debug.WriteLine("Item could not be equipped");
                    MessageBox.Show("Item could not be equipped");
                }
                System.Diagnostics.Debug.WriteLine("Selected Slot " + SelectedSlot);
                RefreshInventory();
            });
            UnequipButton = new RelayCommand(o =>
            {
                if (!Inventory.UnEquipWeapon())
                {
                    System.Diagnostics.Debug.WriteLine("Weapon could not be unequipped");
                    MessageBox.Show("Weapon could not be unequipped");
                }
                RefreshInventory();
            });
            InventoryButton = new RelayCommand(o =>
            {
                try
                {
                    SelectedSlot = int.Parse(o.ToString());

                }
                catch
                {
                    MessageBox.Show("Something went wrong selecting a slot");
                }
                
            });
            RemoveItemButton = new RelayCommand(o =>
            {
                Inventory.RemoveItem(SelectedSlot);
                RefreshInventory();
            });
            RemoveAllItemButton = new RelayCommand(o =>
            {
                Inventory.RemoveAllItem(SelectedSlot);
                RefreshInventory();
            });
        }

        public void RefreshInventory()
        {
            int i = 0;
            foreach (Slot s in Inventory.Slots)
            {
                if (s.Item != null)
                {
                    Slots[i] = "" + s.Item.ItemName + "\n" + s.Amount;
                }
                else
                {
                    Slots[i] = "Nothing";
                }
                i++;
            }
            if (Inventory.WeaponSlot.Item != null)
            {
                System.Diagnostics.Debug.WriteLine("Setting Slot 5 to " + Inventory.WeaponSlot.Item.ItemName);
                Slots[5] = "" + Inventory.WeaponSlot.Item.ItemName;
            }
            else
            {
                Slots[5] = "Nothing";
            }
            SelectedSlot = SelectedSlot;
            OnPropertyChanged("Inventory");
            OnPropertyChanged("Slots");
        }
    }
}
