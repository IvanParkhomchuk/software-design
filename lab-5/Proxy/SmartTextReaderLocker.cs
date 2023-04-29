using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proxy
{
    internal class SmartTextReaderLocker : ISmartTextReader
    {
        private ISmartTextReader _reader;
        private Regex _blackListRegex;

        public SmartTextReaderLocker(ISmartTextReader reader, string blackListPattern)
        {
            this._reader = reader;
            this._blackListRegex = new Regex(blackListPattern);
        }

        public char[][] ReadFile(string filename)
        {
            if (this._blackListRegex.IsMatch(filename))
            {
                throw new Exception($"File {filename} is blacklisted!");
            }

            return _reader.ReadFile(filename);
        }
    }
}
