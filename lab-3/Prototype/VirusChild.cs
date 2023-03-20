using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class VirusChild
    {
        public DateTime[] BirthDate { get; private set; }

        public VirusChild(DateTime[] birthdates)
        {
            this.BirthDate = birthdates;
        }
    }
}
