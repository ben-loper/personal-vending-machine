using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneProject
{
    public class Candy : VendingMachineItem
    {
        public Candy(string itemName, decimal itemPrice) : base(itemName, itemPrice)
        {

        }

        public override string MakeSound()
        {
            return "Munch Munch, Yum!";
        }
    }
}
