using System;
using System.IO;

namespace Exercise04
{
    internal class CompareLines
    {
        private static void Main(string[] args)
        {
            string baseFolder = Path.GetFullPath(@"..\..\..\..\") + @"Textfiles\";
            string firstFile = Path.Combine(baseFolder, "Exercise04A.txt");
            string secondFile = Path.Combine(baseFolder, "Exercise04B.txt");
            Console.WriteLine(firstFile);
            int sameLine = 0;
            int differentLine = 0;
            try
            {
                using (StreamReader firstReader = new StreamReader(firstFile))
                using (StreamReader secondReader = new StreamReader(secondFile))
                {
                    string lineA;
                    while ((lineA = firstReader.ReadLine()) != null)
                    {
                        if (lineA != secondReader.ReadLine())
                        {
                            differentLine++;
                        }
                        else
                        {
                            sameLine++;
                        }
                    }
                }
                Console.WriteLine($"Number of same lines: {sameLine}.");
                Console.WriteLine($"Number of different lines: {differentLine}.");
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("Can not find the files!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid folder path!");
            }
            catch (IOException ex)
            {
                Console.Error.WriteLine("Can not read the files!" + ex.Message);
            }
            Console.WriteLine("Hello World!");
        }
    }
}