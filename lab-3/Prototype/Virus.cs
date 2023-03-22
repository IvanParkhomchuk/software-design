using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Virus : ICloneable
    {
        public decimal Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public VirusChild[] VirusChildren { get; set; }

        public Virus(decimal weight, int age, string name, string type, VirusChild[] virusChildren)
        {
            this.Weight = weight;
            this.Age = age;
            this.Name = name;
            this.Type = type;
            this.VirusChildren = virusChildren;
        }

        public Virus(Virus original)
        {
            this.Weight = original.Weight;
            this.Age = original.Age;
            this.Name = original.Name;
            this.Type = original.Type;
            this.VirusChildren = (VirusChild[])original.VirusChildren.Clone();
        }

        public object Clone()
        {
            return new Virus(this);
        }
    }
}
