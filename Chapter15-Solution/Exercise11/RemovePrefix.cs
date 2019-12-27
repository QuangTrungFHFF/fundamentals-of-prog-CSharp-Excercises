using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Exercise11
{
    internal class RemovePrefix
    {
        /// <summary>
        /// Write a program that deletes all words that begin with the word "test". The words will contain only the following chars: 0…9, a…z, A…Z.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            string sourceFolder = Path.GetFullPath(@"..\..\..\..\") + @"Textfiles\";
            string sourceFile = Path.Combine(sourceFolder, "Exercise11.txt");
            string outputFile = Path.Combine(sourceFolder, "Exercise11out.txt");
            string content = string.Empty;
            try
            {
                using StreamReader streamReader = new StreamReader(sourceFile);
                using StreamWriter streamWriter = new StreamWriter(outputFile);
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    line = Regex.Replace(line, @"\btest\w+", "");
                    line = Regex.Replace(line, @"\btest\b", "");
                    streamWriter.WriteLine(line);
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine($"File not found {sourceFile}");
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine($"Invalid path {sourceFile}");
            }
            catch (IOException ex)
            {
                Console.Error.WriteLine("Can not read/Write the files." + ex.Message);
            }
            Console.WriteLine("Completed!");
        }
    }
}