using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacter
{
    class Inventory
    {
        //int Strength;
        //string ItemName;
        //int CarryCapacity;
        //string ItemDescription;
        //int ItemAmount;
        //bool Encumbered;


        List<Item> InventoryList = new List<Item>();
        UtilityMethods b2 = new UtilityMethods();

        public void AddToInv() //blah blah
        {
            Item B1 = new Item();

            B1.ItemName = b2.ReadTextInput("Please Enter item name");
            B1.ItemType = b2.ReadTextInput("Please Enter item type");
            B1.AmountHeld = b2.ReadNumericInput("Please enter amount");
            B1.WeightPerItem = b2.ReadNumericInput("Please enter eight per item");
            B1.Description = b2.ReadTextInput("Please enter the description of the Item");

            InventoryList.Add(new Item(B1.ItemName, B1.ItemType, B1.AmountHeld, B1.WeightPerItem, B1.Description));

        }
        public void CheckInventory()
        {
            foreach (var Item in InventoryList)
            {
                Console.WriteLine("test: {0}, {1}, {2}, {3}, {4}", Item.ItemName, Item.ItemType, Item.AmountHeld, Item.WeightPerItem, Item.Description);
            }
        }

        public void RemoveItem()
        {
            string itemName = b2.ReadTextInput("Please Enter item name");
            InventoryList.Remove(new Item(itemName));
        }
        //int CarryCapacityCalc()
        //{
        //    CarryCapacity = Strength * 15;

        //    return CarryCapacity;
        //}
        //int ItemWeightCalc()
        //{

        //}
    }
}
