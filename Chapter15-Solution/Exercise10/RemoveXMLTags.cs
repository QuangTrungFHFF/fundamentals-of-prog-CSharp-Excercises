using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Exercise10
{
    /// <summary>
    /// Write a program that extracts from an XML file the text only (without the tags).
    /// </summary>
    class RemoveXMLTags
    {
        static void Main(string[] args)
        {
            string sourceFolder = Path.GetFullPath(@"..\..\..\..\") + @"Textfiles\";
            string sourceFile = Path.Combine(sourceFolder, "Exercise10.txt");
            string outputFile = Path.Combine(sourceFolder, "Exercise10out.txt");
            string content = string.Empty; ;
            var contentWithoutTags = new List<string>();
            try
            {
                using StreamReader streamReader = new StreamReader(sourceFile);
                content = streamReader.ReadToEnd();
                contentWithoutTags =  GetWords(content);
                using StreamWriter streamWriter = new StreamWriter(outputFile);
                foreach(string word in contentWithoutTags)
                {
                    streamWriter.WriteLine(word);
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
        public static List<string> GetWords(string content)
        {
            var result = new List<string>();
            Regex regex = new Regex(@">(?<word>.*?)<");
            MatchCollection words = regex.Matches(content);
            foreach (Match m in words)
            {
                string word = m.Groups[1].Value.Trim();
                if (word != ""&& word != " ")
                {
                    result.Add(m.Groups[1].Value.Trim());
                }

            }
            return result;
        }
    }
}
