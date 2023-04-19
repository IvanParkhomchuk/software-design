using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class FileLoggerAdapter : Logger
    {
        private FileWriter _writer;

        public FileLoggerAdapter()
        {
            _writer = new FileWriter();
        }

        public override void Log(string message)
        {
            _writer.WriteLine("Log: " + message);
        }

        public override void Warn(string message)
        {
            _writer.WriteLine("Warn: " + message);
        }

        public override void Error(string message)
        {
            _writer.WriteLine("Error: " + message);
        }
    }
}
