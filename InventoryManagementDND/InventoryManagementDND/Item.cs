using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagementDND
{
    public class Item
    {
        private string itemName;
        private string itemType;
        private int amountHeld;
        private int weightPerItem;
        private bool canBeEquipped;

        public Item()
        {
        }

        public Item(string itemName, string itemType, int amountHeld, int weightPerItem, bool canBeEquipped)
        {
            this.itemName = itemName;
            this.itemType = itemType;
            this.amountHeld = amountHeld;
            this.weightPerItem = weightPerItem;
            this.canBeEquipped = canBeEquipped;
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value;  }
        }
        public string ItemType
        {
            get { return itemType; }
            set { itemType = value; }
        }
        public int AmountHeld
        {
            get { return amountHeld; }
            set { amountHeld = value; }
        }
        public int WeightPerItem
        {
            get { return weightPerItem; }
            set { weightPerItem = value; }
        }

        public bool CanBeEquipped
        {
            get { return canBeEquipped; }
            set { canBeEquipped = value; }
        }

    }
}
