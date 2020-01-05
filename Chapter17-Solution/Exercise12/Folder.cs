using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Exercise12
{
    class Folder
    {
        public string Name { get; private set; }
        public List<File> Files { get; set; }
        public List<Folder> SubFolders { get; set; }
        public Folder(DirectoryInfo parrent)
        {
            this.Name = parrent.FullName;
            this.Files = GetSubFiles(parrent.FullName);
            this.SubFolders = GetSubFolder(parrent.FullName);
        }
        public Folder(string name)
        {
            this.Name = name;
            this.Files = new List<File>();
            this.SubFolders = new List<Folder>();
        }
        /// <summary>
        /// Get direct files in the folder (Not include files in sub folder)
        /// </summary>
        /// <param name="parrent"></param>
        /// <returns></returns>
        public static List<File> GetSubFiles(string parrent)
        {
            var files = new List<File>();
            try
            {
                DirectoryInfo parrentDir = new DirectoryInfo(parrent);

                int size = Directory.GetFiles(parrent).Length;
                
                for (int i = 0; i < size; i++)
                {
                    files.Add(new File(parrentDir.GetFiles()[i]));
                }
                
            }
            catch (UnauthorizedAccessException)
            {                
            }
            return files;
        }
        /// <summary>
        /// Get list of direct subfolder of current folder
        /// </summary>
        /// <param name="parrent"></param>
        /// <returns></returns>
        public static List<Folder> GetSubFolder(string parrent)
        {
            var childFolders = new List<Folder>();
            try
            {
                DirectoryInfo parrentDir = new DirectoryInfo(parrent);
                int size = parrentDir.GetDirectories().Length;

                for (int i = 0; i < size; i++)
                {
                    childFolders.Add(new Folder(parrentDir.GetDirectories()[i].FullName));
                }
            }
            catch (UnauthorizedAccessException)
            {
            }            
            return childFolders;
        }
        /// <summary>
        /// Get size of current folder
        /// </summary>
        /// <returns></returns>
        public long GetFolderSize()
        {
            long size = 0;
            var folderQueue = new Queue<Folder>();
            var current = this;
            folderQueue.Enqueue(current);
            while (folderQueue.Count > 0)
            {
                current = folderQueue.Dequeue();
                size+=GetFilesSizeInFolder(current);
                foreach(Folder f in current.SubFolders)
                {
                    folderQueue.Enqueue(f);
                }
            }
            return size;

        }
        /// <summary>
        /// Get size of all files in folder (not files in sub folder)
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        private static long GetFilesSizeInFolder(Folder folder)
        {
            long size = 0;
            foreach(File f in folder.Files)
            {
                size += f.Size;
            }
            return size;
        }
    }
}
