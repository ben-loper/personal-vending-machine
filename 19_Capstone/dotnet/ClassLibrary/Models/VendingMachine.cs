using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace CapstoneProject
{
    public class VendingMachine
    {
        public List<VendingMachineItem> ItemsInVendingMachine = new List<VendingMachineItem>();      

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
    }
}
