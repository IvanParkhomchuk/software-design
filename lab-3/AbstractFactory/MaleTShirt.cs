using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MaleTShirt : ITShirt
    {
        public void ReleaseTShirt() => Console.WriteLine("Male T-Shirt");
    }
}
