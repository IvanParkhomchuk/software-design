using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class LightElementNodeType // Flyweight
    {
        public string tagName;
        public string viewType; // block or row
        public bool isDoubleTag; // <h1></h1> or <img/>

        public LightElementNodeType(string tagName, string viewType, bool isDoubleTag)
        {
            this.tagName = tagName;
            this.viewType = viewType;
            this.isDoubleTag = isDoubleTag;
        }
    }
}
