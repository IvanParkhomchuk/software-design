using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class SmartTextChecker : ISmartTextReader
    {
        private ISmartTextReader _reader;

        public SmartTextChecker(ISmartTextReader reader)
        {
            this._reader = reader;
        }

        public char[][] ReadFile(string filename)
        {
            Console.WriteLine("File opening...");

            char[][] matrix = _reader.ReadFile(filename);

            Console.WriteLine("File closing...");

            int rowsAmount = matrix.Length;
            int charsAmount = 0;

            foreach (var row in matrix)
            {
                charsAmount += row.Length;
            }

            Console.WriteLine($"Rows amount: {rowsAmount}, Chars amount: {charsAmount}");

            return matrix;
        }
    }
}
