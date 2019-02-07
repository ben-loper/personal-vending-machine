using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneProject
{
    class Chip : VendingMachineItem
    {

        public Chip(string itemName, decimal itemPrice) : base(itemName, itemPrice)
        {

        }

        public override string MakeSound()
        {
            return "Crunch Crunch, Yum!";
        }
    }
}
