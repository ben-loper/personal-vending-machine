using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneProject
{
    public class Chip : VendingMachineItem
    {

        public Chip(string itemName, decimal itemPrice) : base(itemName, itemPrice)
        {

        }

        public override string MakeSound()
        {
            Sound.PlaySound("Chips.wav");
            return "Crunch Crunch, Yum!";
        }
    }
}
