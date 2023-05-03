using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_1
{
    internal interface LightNode
    {
        public void OuterHTML();
        public void InnerHTML();
        LightNode Clone();

    }
}
