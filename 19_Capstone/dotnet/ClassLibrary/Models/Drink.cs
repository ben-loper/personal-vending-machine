using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneProject
{
    class Drink : VendingMachineItem
    {
        public Drink(string itemName, decimal itemPrice) : base(itemName, itemPrice)
        {

        }

        public override string MakeSound()
        {
            return "Glug Glug, Yum!";
        }
    }
}
