using System;
using System.Collections.Generic;
using System.Text;


namespace CapstoneProject
{
    public class VendingMachine
    {
        public List<VendingMachineItem> ItemsInVendingMachine { get; private set; }

        public void AddItemToListOfItems(VendingMachineItem item)
        {
            ItemsInVendingMachine.Add(item);
        }
    }
}
