using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneProject
{
    class Gum : VendingMachineItem
    {
        public Gum(string itemName, decimal itemPrice) : base(itemName, itemPrice)
        {

        }

        public override string MakeSound()
        {
            return "Chew Chew, Yum!";
        }
    }
}
