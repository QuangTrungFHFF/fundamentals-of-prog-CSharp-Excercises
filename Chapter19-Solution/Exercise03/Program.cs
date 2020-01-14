using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var student = new SortedDictionary<string, SortedSet<Name>>();
            string path = Path.Combine((Path.GetFullPath(@"..\..\..\..\") + @"Textfiles\"), "student.txt");
            try
            {
                using StreamReader streamReader = new StreamReader(path);
                string line = String.Empty;
                string[] words;
                string[] fullName;

                while ((line = streamReader.ReadLine()) != null)
                {
                    words = line.Split("|", StringSplitOptions.RemoveEmptyEntries);
                    fullName = words[0].Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    if (!student.ContainsKey(words[1]))
                    {
                        student.Add(words[1], new SortedSet<Name>());
                    }
                    student[words[1]].Add(new Name(fullName[0], fullName[1]));
                }

                Print(student);
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine($"Cannot find the file at: {path}");
            }
            catch (IOException ex)
            {
                Console.Error.WriteLine($"Error trying reading the file: {path}");
                Console.WriteLine(ex.Message);
            }
        }

        public static void Print(SortedDictionary<string, SortedSet<Name>> student)
        {
            foreach (var s in student)
            {
                Console.WriteLine(s.Key + ": ");
                foreach (var n in s.Value)
                {
                    Console.Write("\t" + n.ToString());
                }
                Console.WriteLine("");
            }
        }
    }
}