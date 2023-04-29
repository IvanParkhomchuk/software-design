using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Composite_1
{
    internal class LightElementNode : LightNode
    {
        private string _tagName;
        private string _viewType;
        private bool _isCloseType;
        private List<string> _classes;
        private List<LightNode> _children;

        public LightElementNode(string tag, string viewType, bool isClose, List<string> classes)
        {
            this._tagName = tag;
            this._viewType = viewType;
            this._isCloseType = isClose;
            this._classes = classes;
            this._children = new List<LightNode>();
        }

        public override LightNode Clone()
        {
            LightElementNode clonedNode = new LightElementNode(this._tagName, this._viewType, this._isCloseType, this._classes);
            foreach (LightNode child in this._children)
            {
                clonedNode.AppendChild(child.Clone());
            }
            return clonedNode;
        }


        public override string OuterHTML()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<").Append(_tagName);

            if (_classes != null && _classes.Count > 0)
            {
                sb.Append(" class=\"");

                foreach (string cls in _classes)
                {
                    sb.Append(cls).Append(" ");
                }

                sb.Remove(sb.Length - 1, 1);
                sb.Append("\"");
            }

            if (_isCloseType)
            { 
                sb.Append(">");
                sb.Append("\n" + InnerHTML() + "\n");
                sb.Append("</").Append(_tagName).Append(">");
            } else {
                sb.Append("/>");
            }

            return sb.ToString();
        }

        public override string InnerHTML()
        {
            StringBuilder sb = new StringBuilder();

            foreach (LightNode child in _children)
            {
                sb.Append(child.OuterHTML());
            }

            return sb.ToString();
        }

        public override void AppendChild(LightNode child)
        {
            _children.Add(child);
        }

        public void ReplaceChild(LightNode replacedItem, int index)
        {
            if (index < 0 || index >= _children.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            _children[index] = replacedItem;
        }

        public void RemoveChild(LightNode child)
        {
            _children.Remove(child);
        }

        public void InsertBefore(LightNode insertedItem, LightNode existingItem)
        {
            int index = _children.IndexOf(existingItem);

            _children.Insert(index, insertedItem);
        }
    }
}
