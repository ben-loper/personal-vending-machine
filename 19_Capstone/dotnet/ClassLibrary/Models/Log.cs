using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VendingMachine.Models
{
    public class Log
    {

        /// <summary>
        /// Given the full file path, reads the pipe delimited items in the file
        /// </summary>
        /// <param name="filePath"></param>
        public static void ReadItemsFromFile(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {

                }
            }
            catch (Exception ex)
            {

            }
        }
            
    }
}
