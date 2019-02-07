using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace CapstoneProject
{
    public class VendingMachine
    {
        public List<VendingMachineItem> ItemsInVendingMachine { get; private set; }      

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
                    string line = sr.ReadLine();

                    String[] items = line.Split("|");


                }
            }
            catch (Exception ex)
            {

            }
        }

        private void CreateVendingMachineItems(List<VendingMachineItem> items)
        {
            foreach (VendingMachineItem item in items)
            {
                
            }
        }

        private void AddItemToListOfItems(VendingMachineItem item)
        {
            ItemsInVendingMachine.Add(item);
        }
    }
}
