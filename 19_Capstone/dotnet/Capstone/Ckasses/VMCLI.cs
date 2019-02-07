using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineCLI
{
    class VMCLI
    {
        public void MainMenu()
        {
            // Load items into vending machine


            //(1) Display Vending Machine Items(2) Purchase(3) Exit


            Console.WriteLine("1) Display Vending Machine Items");
            Console.WriteLine("2) Purchase");
            Console.WriteLine("3) Exit");

            Console.ReadKey();
        }
    }
}
