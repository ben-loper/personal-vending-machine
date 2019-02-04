using System;
using System.IO;

namespace file_io_part1_exercises_pair
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for a filesystem path for a test file

            Console.Write("Please enter the path for a text file: ");
            string filePath = Console.ReadLine();

            //string filePath = @"C:\workspace\team\week-4-pair-exercises-c-team-4\17_FileIO_Reading_in\pair-exercise\dotnet\alices_adventures_in_wonderland.txt";

            // Read the content of the file
            try
            {
                using(StreamReader sr = new StreamReader(filePath))
                {
                    int wordCount = 0;
                    int sentenceCount = 0;

                    
                    while (!sr.EndOfStream)
                    {
                        char currentCharacter = (char)sr.Read();

                        // Determine the number of words (delimited by white space characters)
                        if (currentCharacter.ToString() == " " || currentCharacter.ToString() == "/n")
                        {
                            wordCount++; 
                        }

                        // Determine the number of sentences (delimited by either a period, exclamation mark, or question mark
                        else if (currentCharacter.ToString() == "!" || currentCharacter.ToString() == "." || currentCharacter.ToString() == "?") 
                        {
                            sentenceCount++;
                        }
                    }

                    Console.WriteLine($"Word Count: {wordCount}");
                    Console.WriteLine($"Sentence Count: {sentenceCount}");

                }
            }
            catch (Exception)
            {
                Console.WriteLine("File does not exist");
                Console.ReadKey();
            }
            // Print out the results


            Console.ReadKey();
        }
    }
}
