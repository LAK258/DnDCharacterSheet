using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementDND;

namespace InventoryRunProgram
{
    class Program
    {            

        static void Main(string[] args)
        {
            Inventory I1 = new Inventory();


            I1.AddToInv();
            I1.AddToInv2();
            I1.CheckInventory();

            //List<Item> InventoryList = new List<Item>();
            //InventoryList.Add(new Item("ItemName", "ItemType", 2, 2, true));


            //foreach (var Item in InventoryList)
            //{
            //    Console.WriteLine("test: {0}, {1}, {2}, {3}, {4}", Item.ItemName, Item.ItemType, Item.AmountHeld, Item.WeightPerItem, Item.CanBeEquipped);
            //}

            Console.ReadKey();
        }
    } 
}
