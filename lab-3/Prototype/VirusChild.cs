using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class VirusChild : ICloneable
    {
        public DateTime BirthDate { get; set; }
        public Virus VirusParent { get; set; }

        public VirusChild(DateTime birthdate)
        {
            this.BirthDate = birthdate;
            this.VirusParent = VirusParent;
        }

        public VirusChild(VirusChild original)
        {
            this.BirthDate = original.BirthDate;
            this.VirusParent = original.VirusParent;
        }

        public object Clone()
        {
            return new VirusChild(this);
        }
    }
}
