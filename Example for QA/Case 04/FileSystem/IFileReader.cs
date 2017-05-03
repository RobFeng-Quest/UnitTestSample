using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileSystem
{
    public interface IFileReader
    {
        string ReadAllText(string aPath);
    }

    public class DataFileReader : IFileReader
    {
        public string ReadAllText(string aPath)
        {
            return File.ReadAllText(aPath);
        }
    }
}
