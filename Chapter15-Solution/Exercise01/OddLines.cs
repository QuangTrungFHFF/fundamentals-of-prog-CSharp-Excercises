using System;
using System.IO;

namespace Exercise01
{
    /// <summary>
    /// Write a program that reads a text file and prints its odd lines on the console.
    /// </summary>
    internal class OddLines
    {
        private static void Main(string[] args)
        {
            string path = Path.GetFullPath(@"..\..\..\..\") + @"\Textfiles\";
            Environment.CurrentDirectory = path;
            string fileName = "Exercise01.txt";
            Console.WriteLine("Reads a text file \"Exercise01.txt\"and prints its odd lines on the console.");
            try
            {
                using (StreamReader streamReader = new StreamReader(fileName))
                {
                    int lineCount = 0;
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        lineCount++;
                        if ((lineCount % 2) != 0)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine($"Can not find file {fileName}");
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine($"Invalid directry in the file path: {path}{fileName}");
            }
            catch (IOException ex)
            {
                Console.Error.WriteLine($"Cannot read the file {fileName}." + ex.Message);
            }
        }
    }
}