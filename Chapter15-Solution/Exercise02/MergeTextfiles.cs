using System;
using System.IO;

namespace Exercise02
{
    /// <summary>
    /// Write a program that joins two text files and records the results in a third file.
    /// </summary>
    internal class MergeTextfiles
    {
        private static void Main(string[] args)
        {
            string sourcePath = Path.GetFullPath(@"..\..\..\..\") + @"\Textfiles\";
            Environment.CurrentDirectory = sourcePath;
            string sourceFileA = "Exercise02A.txt";
            string sourceFileB = "Exercise02B.txt";
            string destFile = "NewFileExercise02.txt";
            if (!File.Exists(sourceFileA) || !File.Exists(sourceFileB))
            {
                Console.Error.WriteLine($"Can not find one of the source file ({sourceFileA}/{sourceFileB}!");
            }
            else
            {
                //Create new file by copying first source file.
                //overwrite the destination file if it already exists.
                File.Copy(sourceFileA, destFile, true);
                //Read text from second source file line by line and append it to new file.
                using (var streamWriter = File.AppendText(destFile))
                {
                    using (var streamReader = new StreamReader(sourceFileB))
                    {
                        streamWriter.WriteLine();
                        string line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            streamWriter.WriteLine(line);
                        }
                    }
                }
            }

            Console.WriteLine("Done!");
        }
    }
}