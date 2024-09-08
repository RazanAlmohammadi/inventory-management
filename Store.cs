using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onlineInventoryManagement
{
    public enum SortOrder
    {
        ASC,
        DESC
    }
    public class Store
    {
        private List<Item> _items;
        private int _maximumCapacity;
        public Store(int maximumCapacity)
        {
            _items = new List<Item>();
            _maximumCapacity = maximumCapacity;
        }
        public void AddItem(Item item)
        {
            int currentVolume = GetCurrentVolume();

            if (currentVolume + item.Quantity > _maximumCapacity)
            {
                Console.WriteLine($"Cannot add '{item.Name}': Over capacity.");
                return;
            }
            if (_items.Any(i => i.Name == item.Name))
            {
                throw new Exception("An item with the same name already exists in the store");
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
                throw new KeyNotFoundException($"Item '{name}' not found");
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

        public List<Item> SortByDate(SortOrder sortOrder)
        {
            if (sortOrder == SortOrder.ASC)
            {
                return _items.OrderBy(i => i.CreatedDate).ToList();
            }
            else
            {
                return _items.OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public Dictionary<string, List<Item>> GroupByDate()
        {
            DateTime threeMonthsAgo = DateTime.Now.AddMonths(-3);
            var newArrival = _items.Where(i => i.CreatedDate >= threeMonthsAgo).ToList();
            var oldItems = _items.Where(i => i.CreatedDate < threeMonthsAgo).ToList();

            return new Dictionary<string, List<Item>>
            {
                { "New Arrival", newArrival },
                { "Old", oldItems }
            };
        }
    }

}

