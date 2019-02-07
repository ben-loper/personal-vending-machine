using CapstoneProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CapstoneTests
{
    [TestClass]
    public class VendingMachineTests
    {
        VendingMachine machine = new VendingMachine();

        
        string fullFilePath = Environment.CurrentDirectory + @"\..\..\..\..\etc\vendingmachine.csv";

        


        [TestMethod]
        public void LoadItemsTest()
        {
            machine.LoadItemsFromFile(fullFilePath);

            Assert.AreEqual(16, machine.ItemsInVendingMachine.Count, "16 items are loaded when the machine is loaded");
        }

        [TestMethod]
        public void Add1DollarToMachine()
        {
            machine.AddFunds(1);

            Assert.AreEqual(1, machine.AvailableFunds, "Feed 1 dollar into the machine");

        }

        [TestMethod]
        public void Add2DollarsToMachine()
        {
            machine.AddFunds(2);

            Assert.AreEqual(2,  machine.AvailableFunds, "Feed 2 dollar into the machine");
        }

        [TestMethod]
        public void Add5DollarsToMachine()
        {
            machine.AddFunds(3);

            Assert.AreEqual(5, machine.AvailableFunds, "Feed 5 dollars into machine");
        }
    }
}
