using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneProject
{
    public abstract class VendingMachineItem
    {
        
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; } = 0;
        public string DisplayQuantity
        {
            get
            {
                string result = Quantity.ToString();

                if(Quantity == 0)
                {
                    result = "SOLD OUT";
                }

                return result;
            }
        }


        public VendingMachineItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public abstract string MakeSound();



    }
}
