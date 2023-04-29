using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_2
{
    internal class CompositeArtefact : ArtefactContainer
    {
        public CompositeArtefact(string name, int weight, int powerBuf) : base(name, weight, powerBuf)
        {

        }
    }
}
