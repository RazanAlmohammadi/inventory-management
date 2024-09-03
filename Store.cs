using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onlineInventoryManagement
{
    public class Store
    {
        private List<Item> _items;

        public Store()
        {
            _items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            if (_items.Any(i => i.Name == item.Name))
            {
                Console.WriteLine("An item with the same name already exists in the store");
            }
            _items.Add(item);
        }

        public void DeleteItem(string name)
        {

            int index = _items.FindIndex(i => i.Name == name);

            if (index >= 0)
            {

                _items.RemoveAt(index);
                Console.WriteLine($"Item '{name}' deleted successfully");
            }
            else
            {
                Console.WriteLine($"Item '{name}' not found");
            }
        }

        public int GetCurrentVolume()
        {
            return _items.Sum(i => i.Quantity);
        }

        public Item FindItemByName(string name)
        {
            return _items.SingleOrDefault(i => i.Name == name);
        }

        public List<Item> SortByNameAsc()
        {
            return _items.OrderBy(i => i.Name).ToList();
        }


    }
}
