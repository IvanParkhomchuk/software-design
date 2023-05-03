using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class LightElementNode : LightNode // Context
    {
        private List<string> _cssClasses;
        private List<LightNode> _children = new List<LightNode>();

        private LightElementNodeType _nodeType;

        public LightElementNode(string tagName, string viewType, bool isDoubleTag, List<string> cssClasses)
        {
            this._cssClasses = cssClasses;
            this._nodeType = LightElementNodeTypeFactory.GetLightElementNodeType(tagName, viewType, isDoubleTag);
        }

        public void OuterHTML()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<").Append(this._nodeType.tagName);

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

            if (this._nodeType.isDoubleTag)
            {
                sb.Append(">");
                Console.Write(sb);
                this.InnerHTML();
                Console.Write($"</{this._nodeType.tagName}>");
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
            LightElementNode clonedNode = new LightElementNode(this._nodeType.tagName, this._nodeType.viewType, this._nodeType.isDoubleTag, this._cssClasses);
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
