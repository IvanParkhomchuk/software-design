using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class SmartTextReader : ISmartTextReader
    {
        public char[][] ReadFile(string filename)
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            int binIndex = currentDirectory.IndexOf("bin" + Path.DirectorySeparatorChar);
            if (binIndex > -1)
            {
                currentDirectory = currentDirectory.Substring(0, binIndex);
            }

            string[] lines = File.ReadAllLines(Path.Combine(currentDirectory, filename));

            char[][] matrix = new char[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                matrix[i] = lines[i].ToCharArray();
            }
            return matrix;
        }
    }
}
