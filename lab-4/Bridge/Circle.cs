using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Circle : IShape
    {
        public void Draw() => Console.Write("Drawing Circle ");
    }
}
