using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CapstoneProject
{
    public abstract class Log
    {

        private static string _logFileLocation = Environment.CurrentDirectory + @"\..\..\..\..\etc\Log.txt";

        public static void WriteFeedMoneyToLog(decimal amount, decimal resultAmount)
        {
            File.AppendAllText(_logFileLocation, $"\n{DateTime.Now} FEED MONEY: {amount.ToString("C")}".PadRight(10) + $"{resultAmount.ToString("C")}");
        }

        public static void WritePurchaseToLog(VendingMachineItem item, decimal previousBalance, string location)
        {
            File.AppendAllText(_logFileLocation, $"\n{DateTime.Now} {item.Name} {location}  {previousBalance.ToString("C")}".PadRight(10) + $"{(previousBalance - item.Price).ToString("C")}");
        }

        public static void WriteMakeChangeToLog(string filePath)
        {

        }
    }
}
