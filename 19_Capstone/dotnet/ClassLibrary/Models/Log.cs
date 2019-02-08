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
            WriteToLog($"{DateTime.Now}  ".PadRight(20) + "FEED MONEY:".PadRight(25) + $"{amount.ToString("C")}".PadRight(10) + $"{resultAmount.ToString("C")}".PadRight(20));
        }

        public static void WritePurchaseToLog(VendingMachineItem item, decimal previousBalance, string location)
        {
            WriteToLog($"\n{DateTime.Now}  ".PadRight(20) + $"{item.Name} {location}".PadRight(25) + $"{previousBalance.ToString("C")}".PadRight(10) + $"{(previousBalance - item.Price).ToString("C")}".PadRight(20));
        }

        public static void WriteMakeChangeToLog(decimal previousAmount)
        {
            WriteToLog($"\n{DateTime.Now}  ".PadRight(20) + "GIVE CHANGE:".PadRight(25) + $"{previousAmount.ToString("C")}".PadRight(10) + $"$0.00".PadRight(20));
        }

        public static void WriteToLog(string line)
        {
            using (StreamWriter sw = new StreamWriter(_logFileLocation, true))
            {
                sw.WriteLine(line);
            }
        }
    }
}
