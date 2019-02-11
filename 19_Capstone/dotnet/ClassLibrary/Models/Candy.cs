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

        /// <summary>
        /// Provides sound, overridden by each of the vending machine item subclasses
        /// </summary>
        /// <returns></returns>
        public override string MakeSound()
        {
            Sound.PlaySound("Candy.wav");
            return "Munch Munch, Yum!";
        }
    }
}
