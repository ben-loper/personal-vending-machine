using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneProject
{
    public abstract class VendingMachineItem
    {
        public string ItemLocation { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; } = 5;


        public VendingMachineItem(string itemLocation, String name, decimal price)
        {
            ItemLocation = itemLocation;
            Name = name;
            Price = price;
        }
    }
}
