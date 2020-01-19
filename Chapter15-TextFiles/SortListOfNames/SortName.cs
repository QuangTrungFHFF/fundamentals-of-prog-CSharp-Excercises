using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise06
{
    /// <summary>
    /// Write a program that reads a list of names from a text file, arranges them in alphabetical order, and writes them to another file. The lines are written one per row.
    /// </summary>
    internal class SortName
    {
        private static void Main(string[] args)
        {
            var nameList = new List<FullName>();
            string sourceFolder = Path.GetFullPath(@"..\..\..\..\") + @"Textfiles\";
            string sourceFile = Path.Combine(sourceFolder, "Exercise06.txt");
            string outputFile = Path.Combine(sourceFolder, "Exercise06out.txt");

            try
            {
                //Read name file (each line contains first name and last name)
                using (StreamReader streamReader = new StreamReader(sourceFile))
                {
                    string line;
                    string[] name;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        name = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        nameList.Add(new FullName(name[0], name[1]));
                    }
                }
                //Sort list of name by first name, then sort name
                var newNameList = nameList.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToArray();
                //Write sorted list of name to new file
                foreach (FullName name in newNameList)
                {
                    Console.WriteLine(name);
                }
                using (StreamWriter streamWriter = new StreamWriter(outputFile, false))
                {
                    foreach (FullName name in newNameList)
                    {
                        streamWriter.WriteLine(name.ToString());
                    }
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
            Console.WriteLine("Complete!");
            Console.ReadKey();
        }
    }
}