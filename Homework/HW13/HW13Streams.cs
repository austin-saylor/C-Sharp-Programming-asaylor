using System;
using System.IO;

namespace HW13
{
    class HW13Streams
    {
        static void Main(string[] args)
        {
            // Start the program
            Console.WriteLine("Files and Streams Demo: \n");

            // Define the paths to the original and new files
            string originalFilePath = "original.txt";
            string newFilePath = "new.txt";

            // Create and write to the original file
            using (StreamWriter writer = new StreamWriter(originalFilePath))
            {
                // Write text to the original file. In this case, a message with spelling/grammar errors
                writer.WriteLine("Hello, everywon!");
                writer.WriteLine("This iz a messig from me 2 u abowt how mutch I appreshiate ur work.");
                writer.WriteLine("Thank u 4 being the best cowerkers that 1 can have.");
                writer.WriteLine("Sinserely, Austin.");
            }

            Console.WriteLine($"Original file created at {originalFilePath}");

            // Read the original file content
            string fileContent;
            using (StreamReader reader = new StreamReader(originalFilePath))
            {
                fileContent = reader.ReadToEnd();
            }

            // Manipulate the data using StringReader, and write it to the new file
            using (StringReader stringReader = new StringReader(fileContent))
            {
                using (StreamWriter writer = new StreamWriter(newFilePath))
                {
                    string line;
                    while ((line = stringReader.ReadLine()) != null)
                    {
                        // Manipulate the data (e.g., convert to uppercase)
                        string manipulatedLine = line.ToUpper();
                        writer.WriteLine(manipulatedLine);
                    }
                }
            }

            Console.WriteLine($"Manipulated file created at {newFilePath}");
        }
    }
}
