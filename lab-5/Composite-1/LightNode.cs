using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_1
{
    abstract class LightNode
    {
        public abstract string OuterHTML();
        public abstract string InnerHTML();
        public abstract LightNode Clone();
        public virtual void AppendChild(LightNode child) { }
        public virtual void RemoveChild(LightNode child) { }
        public virtual void ReplaceChild(LightNode replacedItem, int index) { }
        public virtual void InsertBefore(LightNode insertedItem, LightNode existingItem) { }
    }
}
