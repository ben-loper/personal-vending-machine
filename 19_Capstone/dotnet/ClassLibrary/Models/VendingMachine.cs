﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace CapstoneProject
{
    public class VendingMachine
    {
        // Member Variables
        public List<VendingMachineItem> ItemsInVendingMachine = new List<VendingMachineItem>();

        // Properties
        public decimal AvailableFunds { get; private set; } = 0;

        /// <summary>
        /// Given the full file path, reads the pipe delimited items in the file
        /// </summary>
        /// <param name="filePath"></param>
        public void LoadItemsFromFile(string filePath)
        {        
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        string[] item = line.Split("|");

                        ItemsInVendingMachine.Add(CreateItem(item));
                    }

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Create a VendingMachineItem given array of strings from file
        /// </summary>
        /// <param name="item">Array of items from file</param>
        public VendingMachineItem CreateItem(string [] item)
        {
            VendingMachineItem result;

            if (item[3] == "Chip")
            {
                 result = new Chip(item[0], item[1], decimal.Parse(item[2]));
            }
            else if (item[3] == "Candy")
            {
                result = new Candy(item[0], item[1], decimal.Parse(item[2]));
            }
            else if (item[3] == "Drink")
            {
                result = new Drink(item[0], item[1], decimal.Parse(item[2]));
            }
            else
            {
                result = new Gum(item[0], item[1], decimal.Parse(item[2]));
            }

            return result;

        }

        public void AddFunds(int selection)
        {
            if (selection == 1)
            {
                AvailableFunds += 1;
            }
            else if (selection == 2)
            {
                AvailableFunds += 2;
            }
            else if (selection == 3)
            {
                AvailableFunds += 5;
            }
            else if (selection == 4)
            {
                AvailableFunds += 10;
            }
        }
    }
}
