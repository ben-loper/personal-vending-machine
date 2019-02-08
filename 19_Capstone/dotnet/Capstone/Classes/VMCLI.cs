using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineCLI.Classes;
using VendingMachine.Exceptions;

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

                Console.WriteLine();

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
            bool quit = false;

            while (!quit)
            {
                Console.Clear();

                Console.WriteLine("Slot Location".PadRight(20) + "Product Name".PadRight(20) + "Price".PadRight(10) + "Quantity");

                foreach (var item in machine.ItemsInVendingMachine)
                {
                    PrintItem(machine.ItemsInVendingMachine[item.Key], item.Key);
                }

                Console.WriteLine("\n");

                Console.WriteLine($"Current Money Provided: {machine.AvailableFunds.ToString("C")}");

                

                Console.Write("Select slot location or enter Q to return to the main menu: ");

                string userSelection = Console.ReadLine().ToUpper();

                try
                {
                    if (userSelection.ToLower() == "q")
                    {
                        quit = true;
                    }
                    else
                    {
                        machine.PurchaseItem(userSelection);
                        DispensedItemMenu(userSelection, machine);
                    }
                }
                catch (InvalidSlotException ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("\nPress any key to return to the purchase menu...");
                    Console.ReadKey();
                }
                catch (OutOfStockException ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("\nPress any key to return to the purchase menu...");
                    Console.ReadKey();
                }
                catch (InsufficientFundsException ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("\nPress any key to return to the purchase menu...");
                    Console.ReadKey();
                }
            }
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

                Console.WriteLine("\n");

                Console.WriteLine($"Current Money Provided: {machine.AvailableFunds.ToString("C")}");

                Console.WriteLine("\n");

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
<<<<<<< HEAD
                    machine.GetChange(machine.AvailableFunds);
                   // Console.WriteLine($"Change provided: {qCount} quarter(s), {dCount} dime(s), and {nCount} nickel(s)");

=======
                    Console.WriteLine();
                    Console.WriteLine("\nChange received:");
                    Console.WriteLine();
                    foreach(var item in machine.GetChange(machine.AvailableFunds))
                    {
                        Console.WriteLine($"{item.Value} {item.Key}");
                    }
                    Console.ReadKey();
>>>>>>> e39e9ff02462a4fd048026e2188fc222edc287bf

                    quit = true;

                    
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
                Console.WriteLine("\n");

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

        private static void PrintItem(VendingMachineItem item, string itemLocation)
        {
            Console.WriteLine($"{itemLocation}".PadRight(20) + $"{item.Name}".PadRight(20) + $"{item.Price.ToString("C")}".PadRight(10) + $"{item.DisplayQuantity}");
        }

        public void DispensedItemMenu(string userSelection, VendingMachine machine)
        {
            bool quit = false;

            while (!quit)
            {
                Console.Clear();
                
                Console.WriteLine($"{machine.ItemsInVendingMachine[userSelection].Name}");
                
                Console.WriteLine($"{machine.ItemsInVendingMachine[userSelection].Price.ToString("C")}");
                
                Console.WriteLine($"{machine.ItemsInVendingMachine[userSelection].MakeSound()}");

                Console.Write("Push any button to go back to purchase menu...");

                Console.ReadKey();

                quit = true;
            }



            

            
        }

    }
}
