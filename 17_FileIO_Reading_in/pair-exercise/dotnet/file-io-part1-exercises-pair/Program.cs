using System;
using System.IO;

namespace file_io_part1_exercises_pair
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for a filesystem path for a test file

            Console.WriteLine("Please enter the path for a text file: ");
            string filePath = Console.ReadLine();

            //string filePath = @"C:\workspace\team\week-4-pair-exercises-c-team-4\17_FileIO_Reading_in\pair-exercise\dotnet\alices_adventures_in_wonderland.txt";

            // Read the content of the file
            try
            {
                int wordCount = 0;
                int sentenceCount = 0;

                string[] wordDelimiters = new string[] { " ", "\n", "\t", "\r"};
                
                string[] sentenceDelimiters = new string[] { "!", ".", "?" };

                string passage = File.ReadAllText(filePath);


                string[] wordCountArray = passage.Split(wordDelimiters, StringSplitOptions.RemoveEmptyEntries);

                wordCount = wordCountArray.Length;

                string[] sentenceCountArray = passage.Split(sentenceDelimiters, StringSplitOptions.RemoveEmptyEntries);

                sentenceCount = sentenceCountArray.Length;

                Console.WriteLine($"\nWord Count: {wordCount}");
                Console.WriteLine($"Sentence Count: {sentenceCount}");

                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("\nFile does not exist");
                Console.ReadKey();
            }
            // Print out the results
   
        }
    }
}
