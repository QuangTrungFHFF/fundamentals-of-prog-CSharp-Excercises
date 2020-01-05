using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise12
{
    internal class FolderTree
    {
        public Folder Root { get; private set; }

        public FolderTree(DirectoryInfo root)
        {
            CreateFolderTree(root);
        }

        private void CreateFolderTree(DirectoryInfo root)
        {
            this.Root = new Folder(root.FullName);
            Folder current = this.Root;
            var directoryQueue = new Queue<Folder>();
            directoryQueue.Enqueue(current);
            while (directoryQueue.Count > 0)
            {
                current = directoryQueue.Dequeue();
                current.Files = Folder.GetSubFiles(current.Name);
                current.SubFolders = Folder.GetSubFolder(current.Name);
                foreach (Folder child in current.SubFolders)
                {
                    directoryQueue.Enqueue(child);
                }
            }
        }

        /// <summary>
        /// Find folder with given name and print to console the size of that folder
        /// </summary>
        /// <param name="fullname"></param>
        public void FindFolderSize(string fullname)
        {
            Folder folder = null;
            var directoryQueue = new Queue<Folder>();
            Folder current = this.Root;
            directoryQueue.Enqueue(current);
            while (directoryQueue.Count > 0)
            {
                current = directoryQueue.Dequeue();
                if (current.Name.Equals(fullname))
                {
                    folder = current;
                    break;
                }
                else
                {
                    foreach (Folder child in current.SubFolders)
                    {
                        directoryQueue.Enqueue(child);
                    }
                }
            }
            if (folder == null)
            {
                Console.WriteLine("Cannot find folder: {0}", fullname);
            }
            else
            {
                Console.WriteLine("Size of folder {0} is: {1:N0} bytes", fullname, folder.GetFolderSize());
            }
        }

        public void PrintFolderTree()
        {
            var directoryQueue = new Queue<Folder>();
            Folder current = this.Root;
            directoryQueue.Enqueue(current);
            while (directoryQueue.Count > 0)
            {
                current = directoryQueue.Dequeue();
                Console.WriteLine(current.Name);
                foreach (Folder f in current.SubFolders)
                {
                    directoryQueue.Enqueue(f);
                }
            }
        }
    }
}