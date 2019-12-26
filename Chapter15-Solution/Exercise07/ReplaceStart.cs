using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise07
{
    /// <summary>
    /// Write a program that replaces every occurrence of the substring "start" with "finish" in a text file. Can you rewrite the program to replace whole words only?
    /// </summary>

    class ReplaceStart
    {
        static void Main(string[] args)
        {            
            string sourceFolder = Path.GetFullPath(@"..\..\..\..\") + @"Textfiles\";
            string sourceFile = Path.Combine(sourceFolder, "Exercise07.txt");
            string outputFile = Path.Combine(sourceFolder, "Exercise07out.txt");
            string content = String.Empty;
            string pattern = @"\bstart\b";
            try
            {
                content = GetFileContent(sourceFile);
                content = Regex.Replace(content,pattern," finish ",RegexOptions.IgnoreCase);
                using (StreamWriter streamWriter = new StreamWriter(outputFile, false,Encoding.Unicode))
                {
                    streamWriter.Write(content);
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
        /// <summary>
        /// Read input file line by line
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string GetFileContent(string filePath)
        {
            StringBuilder result = new StringBuilder();
            using(StreamReader streamReader = new StreamReader(filePath))
            {
                string line;
                while((line = streamReader.ReadLine())!= null)
                {
                    result.Append(line);
                    if(!streamReader.EndOfStream)
                    {
                        result.Append(Environment.NewLine);
                    }                   
                }
            }
            return result.ToString();
        }
    }
}
