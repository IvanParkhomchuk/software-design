using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FemaleShoes : IShoes
    {
        public void ReleaseShoes() => Console.WriteLine("Female shoes");
    }
}
