using System;
using System.IO;

namespace Exercise03
{
    /// <summary>
    /// Write a program that reads the contents of a text file and inserts the line numbers at the beginning of each line, then rewrites the file contents.
    /// </summary>
    internal class AddLineNumber
    {
        private static void Main(string[] args)
        {
            string sourceName = "Exercise03.txt";
            string tempName = "Exercise03temp.txt";
            string baseFolder = Path.GetFullPath(@"..\..\..\..\") + @"Textfiles\";
            string sourceFile = Path.Combine(baseFolder, sourceName);
            string tempFile = Path.Combine(baseFolder, tempName);
            try
            {
                using (StreamReader streamReader = new StreamReader(sourceFile))
                using (StreamWriter streamWriter = new StreamWriter(tempFile))
                {
                    string line;
                    int lineCount = 0;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        lineCount++;
                        streamWriter.WriteLine(InsertLineNumber(line, lineCount));
                    }
                }
                File.Replace(tempFile, sourceFile, null);
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("Cannot find the source file!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid folder path!");
            }
            catch (IOException ex)
            {
                Console.Error.WriteLine("Cannot read/write the file!" + ex.Message);
            }
            Console.WriteLine("Added Line number to the source file.");
            Console.ReadKey();
        }

        /// <summary>
        /// Insert line number at the start of the string
        /// </summary>
        /// <param name="content">Content of the line</param>
        /// <param name="lineCount"></param>
        /// <returns></returns>
        public static string InsertLineNumber(string content, int lineCount)
        {
            return string.Format($"Line {lineCount}: {content}");
        }
    }
}