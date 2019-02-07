using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneProject
{
    public abstract class VendingMachineItem
    {
        
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Quantity { get; set; } = "5";


        public VendingMachineItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }


    }
}
