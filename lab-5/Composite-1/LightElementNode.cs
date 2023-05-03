using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_1
{
    internal class LightElementNode : LightNode
    {
        private string _tagName;
        private string _viewType; // block or row
        private bool _isDoubleTag; // <h1></h1> or <img/>
        private List<string> _cssClasses;
        private List<LightNode> _children = new List<LightNode>();

        public LightElementNode(string tagName, string viewType, bool isDoubleTag, List<string> cssClasses)
        {
            this._tagName = tagName;
            this._viewType = viewType;
            this._isDoubleTag = isDoubleTag;
            this._cssClasses = cssClasses;
        }

        public void OuterHTML()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<").Append(_tagName);

            if (_cssClasses != null && _cssClasses.Count > 0)
            {
                sb.Append(" class=\"");

                foreach (string cls in _cssClasses)
                {
                    sb.Append(cls).Append(" ");
                }

                sb.Remove(sb.Length - 1, 1);
                sb.Append("\"");
            }

            if (this._isDoubleTag)
            {
                sb.Append(">");
                Console.WriteLine(sb);
                this.InnerHTML();
                Console.WriteLine($"</{this._tagName}>");
                //sb.Append("</").Append(_tagName).Append(">");
            }
            else
            {
                sb.Append("/>");
                Console.WriteLine(sb);
            }

            //Console.WriteLine(sb.ToString());
        }

        public void InnerHTML()
        {
            foreach (LightNode child in _children)
            {
                child.OuterHTML();
            }
        }

        public LightNode Clone()
        {
            LightElementNode clonedNode = new LightElementNode(this._tagName, this._viewType, this._isDoubleTag, this._cssClasses);
            foreach (LightNode child in this._children)
            {
                clonedNode.AppendChild(child.Clone());
            }
            return clonedNode;
        }

        public void AppendChild(LightNode child)
        {
            this._children.Add(child);
        }

        public void RemoveChild(LightNode child)
        {
            this._children.Remove(child);
        }

        public void ReplaceChild(LightNode oldChild, LightNode newChild)
        {
            int index = _children.IndexOf(oldChild);
            if (index != -1)
            {
                _children[index] = newChild;
            }
        }

        public void InsertBefore(LightNode newChild, LightNode refChild)
        {
            int index = this._children.IndexOf(refChild);

            if (index >= 0)
            {
                this._children.Insert(index, newChild);
            }
        }
    }
}
