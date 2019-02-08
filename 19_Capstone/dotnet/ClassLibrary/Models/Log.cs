using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CapstoneProject
{
    public abstract class Log
    {

        public static void WriteFeedMoneyToLog(decimal amount, decimal resultAmount)
        {
            string logFileLocation = Environment.CurrentDirectory + @"\..\..\..\..\etc\Log.txt";

            using (StreamWriter sw = new StreamWriter(logFileLocation))
            {
                sw.WriteLine(DateTime.Now + " FEED MONEY:" + $"{amount.ToString("C")}" + $"{resultAmount.ToString("C")}");
            } 
        }

        public static void WritePurchaseToLog(string filePath)
        {

        }

        public static void WriteMakeChangeToLog(string filePath)
        {

        }
    }
}
