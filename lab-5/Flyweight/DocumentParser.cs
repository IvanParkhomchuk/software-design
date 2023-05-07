using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class DocumentParser
    {
        public string[] _readFile(string src)
        {
            string content = "";

            using (WebClient client = new WebClient())
            {
                content = client.DownloadString(src);
            }

            string[] lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            return lines;
        }
    }
}
