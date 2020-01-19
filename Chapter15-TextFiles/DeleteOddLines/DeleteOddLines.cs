using System;
using System.IO;
using System.Text;

namespace Exercise09
{
    internal class DeleteOddLines
    {
        private static void Main(string[] args)
        {
            string sourceFolder = Path.GetFullPath(@"..\..\..\..\") + @"Textfiles\";
            string sourceFile = Path.Combine(sourceFolder, "Exercise09.txt");
            string outputFile = Path.Combine(sourceFolder, "Exercise09out.txt");
            try
            {
                string content = DeleteLines(sourceFile);
                using (StreamWriter streamWriter = new StreamWriter(outputFile, false, Encoding.Unicode))
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

            Console.WriteLine("Completed!");
        }

        /// <summary>
        /// Get new file with only even lines
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string DeleteLines(string filePath)
        {
            StringBuilder result = new StringBuilder();
            if (File.Exists(filePath))
            {
                using StreamReader streamReader = new StreamReader(filePath);
                string line;
                int count = 0;
                while ((line = streamReader.ReadLine()) != null)
                {
                    count++;
                    if (count % 2 == 0)
                    {
                        result.Append(line);
                        if (!streamReader.EndOfStream)
                        {
                            result.Append(Environment.NewLine);
                        }
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("Can not find the file" + filePath);
            }
            return result.ToString();
        }
    }
}