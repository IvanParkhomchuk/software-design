using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Tringle : IShape
    {
        public void Draw() => Console.Write("Drawing Tringle ");
    }
}
