using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacter
{
     public class Item
    {
        private string itemName;
        private string itemType;
        private int amountHeld;
        private int weightPerItem;
        private string description;

        public Item()
        {
        }

        public Item(string itemName)
        {
            this.itemName = itemName;
        }

        public Item(string itemName, string itemType, int amountHeld, int weightPerItem, string description)
        {
            this.itemName = itemName;
            this.itemType = itemType;
            this.amountHeld = amountHeld;
            this.weightPerItem = weightPerItem;
            this.description = description;
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
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

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

    }
}
