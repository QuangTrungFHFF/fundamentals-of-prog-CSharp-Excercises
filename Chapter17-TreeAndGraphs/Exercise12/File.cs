using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Exercise12
{
    public class File
    {
        public string Name { get; set; }
        public long Size { get; private set; }
        public File(FileInfo fileInfo)
        {
            this.Name = fileInfo.FullName;
            this.Size = fileInfo.Length;
        }
    }
}
