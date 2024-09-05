﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace onlineInventoryManagement
{
    public class Program
    {
        public static void Main()
        {
            Store store = new Store(100);
            var waterBottle = new Item("Water Bottle", 10, new DateTime(2023, 1, 1));
            var chocolateBar = new Item("Chocolate Bar", 15, new DateTime(2023, 2, 1));
            var coffee = new Item("Coffee", 20);
            var notebook = new Item("Notebook", 5, new DateTime(2023, 3, 1));
            var pen = new Item("Pen", 20, new DateTime(2023, 4, 1));
            var tissuePack = new Item("Tissue Pack", 30, new DateTime(2023, 5, 1));
            var chipsBag = new Item("Chips Bag", 25, new DateTime(2023, 6, 1));
            var sodaCan = new Item("Soda Can", 8, new DateTime(2023, 7, 1));
            var soap = new Item("Soap", 12, new DateTime(2023, 8, 1));
            var shampoo = new Item("Shampoo", 40, new DateTime(2023, 9, 1));
            var toothbrush = new Item("Toothbrush", 50, new DateTime(2023, 10, 1));

            try
            {
                store.AddItem(waterBottle);
                store.AddItem(chocolateBar);
                store.AddItem(coffee);
                store.AddItem(notebook);
                store.AddItem(pen);
                store.AddItem(tissuePack);
                store.AddItem(chipsBag);
                store.AddItem(sodaCan);
                store.AddItem(soap);
                store.AddItem(shampoo);
                store.AddItem(toothbrush);
                store.DeleteItem("Soa");
                store.DeleteItem("Toothbrush");
                var sortedItems = store.SortByNameAsc();
                Console.WriteLine("Items sorted by name:");
                foreach (var item in sortedItems)
                {
                    Console.WriteLine($"{item.Name}, Quantity: {item.Quantity}");
                }

                var foundItem = store.FindItemByName("Coffee");
                if (foundItem != null)
                {
                    Console.WriteLine("Found Item: " + foundItem.Name + " , Quantity: " + foundItem.Quantity);
                }
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"Error : {ex.Message}");

            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");

            }
            Console.WriteLine($"Current Volume: {store.GetCurrentVolume()}");

            var groupByDate = store.GroupByDate();
            foreach (var group in groupByDate)
            {
                Console.WriteLine($"{group.Key} Items:");
                foreach (var item in group.Value)
                {
                    Console.WriteLine($" - {item.Name}, Created: {item.CreatedDate.ToShortDateString()}");
                }
            }
        }
    }
}