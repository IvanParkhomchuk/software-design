using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Virus
    {
        public decimal Weight { get; private set; }
        public int Age { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }
        public VirusChild[] virusChildren { get; private set; }

        public Virus(decimal weight, int age, string name, string type, VirusChild[] virusChildren)
        {
            this.Weight = weight;
            this.Age = age;
            this.Name = name;
            this.Type = type;
            this.virusChildren = virusChildren;
        }
    }
}
