using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_1
{
    internal class LightTextNode : LightNode
    {
        private string _text;

        public LightTextNode(string text)
        {
            this._text = text;
        }

        public override LightNode Clone()
        {
            return new LightTextNode(this._text);
        }

        public override string OuterHTML()
        {
            return _text;
        }

        public override string InnerHTML()
        {
            return "";
        }
    }
}
