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

        public void OuterHTML()
        {
            Console.WriteLine(this._text);
        }

        public void InnerHTML()
        {
            Console.WriteLine(this._text);
        }

        public LightNode Clone()
        {
            return new LightTextNode(this._text);
        }
    }
}
