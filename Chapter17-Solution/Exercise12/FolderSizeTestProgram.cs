using System;
using System.Globalization;
using System.IO;

namespace Exercise12
{
    /// <summary>
    /// Define classes File {string name, int size} and Folder {string name, File[] files, Folder[] childFolders}.
    /// Using these classes, build a tree that contains all files and directories on your hard disk, starting from C:\Windows\.
    /// Write a method that calculates the sum of the sizes of files in a sub-tree and a program that tests this method.    
    /// </summary>
    class FolderSizeTestProgram
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-us");  
            //Set root folder
            var root = new DirectoryInfo(@"D:\Unterhaltung\Videosammlung");
            FolderTree folderTree = new FolderTree(root);
            //Print all folder tree to Console
            folderTree.PrintFolderTree();
            //Get size of root folder
            long size = folderTree.Root.GetFolderSize();
            Console.WriteLine("{0} bytes",size.ToString("N0",culture));
            //Find and print size of sub folder
            folderTree.FindFolderSize(@"D:\Unterhaltung\Videosammlung\AMV");
        }
        
    }
}
