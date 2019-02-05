using System;
using System.IO;

namespace FindAndReplace
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Please enter the search phrase: ");
            string searchPhrase = Console.ReadLine();

            Console.WriteLine("Please enter the replace phrase: ");
            string replacePhrase = Console.ReadLine();



            Console.WriteLine("Please enter the source file path for a text file: ");
            string sourceFilePath = Console.ReadLine();
            //string sourceFilePath = @"C:\workspace\team\week-4-pair-exercises-c-team-4\17_FileIO_Reading_in\pair-exercise\dotnet\alices_adventures_in_wonderland.txt";
            while(!File.Exists(sourceFilePath))
            {
                Console.Clear();
                Console.WriteLine("Entered source file path doesn't exist. Please enter another correct path.");
                sourceFilePath = Console.ReadLine();
            }


            Console.WriteLine("Please enter the destination file path for a text file: ");
            string destinationFilePath = Console.ReadLine();
            //string destinationFilePath = @"C:\workspace\team\week-4-pair-exercises-c-team-4\17_FileIO_Reading_in\pair-exercise\dotnet\alices_adventures_in_wonderland_replacement.txt";

            if(File.Exists(destinationFilePath))
            {
                Console.WriteLine("File already exists. Program will close.");
                Console.ReadKey();
            }
            else
            {
                try
                {
                    Console.WriteLine($"Searching through source document for {searchPhrase} and replacing it with {replacePhrase}");

                    using (StreamReader sr = new StreamReader(sourceFilePath))
                    {
                        using (StreamWriter sw = new StreamWriter(destinationFilePath, true))
                        {


                            while (!sr.EndOfStream)
                            {
                                string line = sr.ReadLine();
                                string fixedLine = line.Replace(searchPhrase, replacePhrase);
                                sw.WriteLine(fixedLine);

                            }
                        }
                    }

                }
                catch
                {
                    Console.WriteLine("File doesn't exist.");
                }
                Console.ReadKey();
            }
        }

            
    }
}


