using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineCLI.Classes;

namespace CapstoneProject
{
    public class VMCLI
    {
        public void MainMenu()
        {
            // Load items into vending machine
            VendingMachine machine = new VendingMachine();

            LoadItems(machine);

            

            //(1) Display Vending Machine Items(2) Purchase(3) Exit

            bool quitMenu = false;

            while (!quitMenu)
            {
                Console.Clear();
                Console.WriteLine("1) Display Vending Machine Items");
                Console.WriteLine("2) Purchase");
                Console.WriteLine("3) Exit");
                Console.WriteLine("4) Sales Report");

                int selection = CLIHelper.GetSingleInteger("Select an option...", 1, 4);

                if (selection == 1)
                {
                    DisplayMenu(machine);
                }
                else if (selection == 2)
                {
                    PurchaseMenu(machine);

                }
                else if (selection == 3)
                {
                    Console.Clear();
                    quitMenu = true;
                }
                else if (selection == 4)
                {
                    //Sales report
                }


            }


        }



        /// <summary>
        /// Loads items into machine object upon project start 
        /// </summary>
        private void LoadItems(VendingMachine machine)
        {
            string fullFilePath = Environment.CurrentDirectory + @"\..\..\..\..\etc\vendingmachine.csv";

            machine.LoadItemsFromFile(fullFilePath);
        }

        public void DisplayMenu(VendingMachine machine)
        {
            Console.Clear();
            foreach (var item in machine.ItemsInVendingMachine)
            {
                Console.WriteLine($"Location: {item.Key}\nName: {item.Value.Name}\nPrice: {item.Value.Price}\nQuantity: {item.Value.Quantity}\n");
                Console.WriteLine($"Current Money Provided: {machine.AvailableFunds.ToString("C")}");
            }
            Console.ReadKey();
        }

        public void PurchaseMenu(VendingMachine machine)
        {
            bool quit = false;

            while (!quit)
            {
                Console.Clear();
                Console.WriteLine("1) Feed Money");
                Console.WriteLine("2) Select Product");
                //Display items
                Console.WriteLine("3) Finish Transaction");

                Console.WriteLine($"Current Money Provided: {machine.AvailableFunds.ToString("C")}");

                int selection = CLIHelper.GetSingleInteger("Select an option...", 1, 3);

                if (selection == 1)
                {
                    FeedMoneyMenu(machine);
                }
                else if (selection == 2)
                {
                    DisplayMenu(machine);

                }
                else if (selection == 3)
                {
                    quit = true;
                    //Console.WriteLine($"Change provided: {qCount} quarter(s), {dCount} dime(s), and {nCount} nickel(s)");
                }
            }
        }
        public void FeedMoneyMenu(VendingMachine machine)
        {
            bool quit = false;

            while (!quit)
            {
                Console.Clear();
                Console.WriteLine("1) $1");
                Console.WriteLine("2) $2");
                Console.WriteLine("3) $5");
                Console.WriteLine("4) $10");
                Console.WriteLine("5) Back");
                Console.WriteLine();

                Console.WriteLine($"Current Money Provided: {machine.AvailableFunds.ToString("C")}");

                int selection = CLIHelper.GetSingleInteger("Select an option...", 1, 5);

                if (selection < 5)
                {
                    machine.AddFunds(selection);
                }
                else if (selection == 5)
                {
                    quit = true;
                }
            }
        }

    }
}
