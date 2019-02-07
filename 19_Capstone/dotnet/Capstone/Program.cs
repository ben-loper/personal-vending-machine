using System;
using VendingMachineCLI;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            VMCLI startUp = new VMCLI();
            startUp.MainMenu();
        }
    }
}
