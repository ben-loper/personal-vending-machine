using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneProject
{
    public class Drink : VendingMachineItem
    {
        public Drink(string itemName, decimal itemPrice) : base(itemName, itemPrice)
        {

        }

        public override string MakeSound()
        {
            Sound.PlaySound("Drink.wav");
            return "Glug Glug, Yum!";
        }
    }
}
