using System;
using System.Collections.Generic;
using System.Text;


namespace InventoryManagementDND
{
    public class Inventory
    {
        //int Strength;
        //string ItemName;
        //int CarryCapacity;
        //string ItemDescription;
        //int ItemAmount;
        //bool Encumbered;

       
        List<Item> InventoryList = new List<Item>(); // laver en liste
        Item B1 = new Item(); // laver et nyt item
        public void AddToInv() // tilføjer item til listen
        {
            Console.WriteLine("Please enter item name");

            InventoryList.Add(new Item(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToBoolean(Console.ReadLine())));


        }
        public void AddToInv2()
        {
            
            Console.WriteLine("Please enter item name");
            B1.ItemName = Console.ReadLine();
            Console.WriteLine("Please enter item type");
            B1.ItemType = Console.ReadLine();
            Console.WriteLine("Please enter amount");
            B1.AmountHeld = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter item weight");
            B1.WeightPerItem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter True or False");
            B1.CanBeEquipped = Convert.ToBoolean(Console.ReadLine());

            InventoryList.Add(new Item(B1.ItemName, B1.ItemType, B1.AmountHeld, B1.WeightPerItem, B1.CanBeEquipped));


        }
        public void CheckInventory()
        {
            foreach (var Item in InventoryList)
            {
                Console.WriteLine("test: {0}, {1}, {2}, {3}, {4}", Item.ItemName, Item.ItemType, Item.AmountHeld, Item.WeightPerItem, Item.CanBeEquipped);
            }
        }       

    //int CarryCapacityCalc()
    //{
    //    CarryCapacity = Strength * 10;

    //    return CarryCapacity;
    //}
    //int ItemWeightCalc()
    //{

    //}
}
}
