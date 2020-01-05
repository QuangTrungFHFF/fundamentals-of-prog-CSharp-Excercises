using System;
using System.IO;

namespace Exercise11
{
    /// <summary>
    /// Write a program that searches the directory C:\Windows\ and all its subdirectories recursively and prints all the files which have extension *.exe.
    /// </summary>
    class ExePrint
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows\");
            PrintExe(dir);

        }
        public static void PrintExe(DirectoryInfo dir)
        {
            FileInfo[] exeFiles;
            try
            {
                exeFiles = dir.GetFiles("*.exe");
                
            }
            catch (UnauthorizedAccessException)
            {
                return;
            }            
            foreach(FileInfo exe in exeFiles)
            {
                Console.WriteLine(exe.FullName);
            }
            foreach(DirectoryInfo d in dir.GetDirectories())
            {                
                PrintExe(d);
            }
        }
    }
}
