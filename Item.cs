using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Item
    {
    private string _name;
    private int _quantity;
    private DateTime _createdDate;


    public Item(string name, int quantity, DateTime? createdDate = null)
    {
        _name = name;
        if (quantity < 0)
        {
            Console.WriteLine("Quantity cannot be negative");
        }
        _quantity = quantity;
        _createdDate = createdDate ?? DateTime.Now;
    }

    public string Name
    {
        get { return _name; }
    }

    public int Quantity
    {
        get { return _quantity; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Quantity cannot be negative");
            }
            _quantity = value;
        }
    }

    public DateTime CreatedDate
    {
        get { return _createdDate; }
    }

}
