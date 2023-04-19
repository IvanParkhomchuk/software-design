using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace Adapter
{
    internal class FileWriter
    {
        private readonly string _fileName = "Logs.txt";
        private string _currentDirectory = Directory.GetCurrentDirectory();

        private string GetFilePath()
        {
            int binIndex = _currentDirectory.IndexOf("bin" + Path.DirectorySeparatorChar);
            if (binIndex > -1)
            {
                _currentDirectory = _currentDirectory.Substring(0, binIndex);
            }

            return Path.Combine(_currentDirectory, _fileName);
        }

        public void Write(string text)
        {
            string filePath = GetFilePath();

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.Write(text);
            }
        }

        public void WriteLine(string text)
        {
            string filePath = GetFilePath();

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(text);
            }
        }
    }
}
