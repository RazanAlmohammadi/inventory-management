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
        _quantity = quantity;
        _createdDate = createdDate ?? DateTime.Now;

        
    }
    
}
