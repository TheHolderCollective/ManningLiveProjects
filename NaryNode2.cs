using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naray_node2
{
    internal class NaryNode<T>
    {
        internal T Value { get; set; }
        internal List<NaryNode<T>> Children;

        internal NaryNode(T value)
        {
            Value = value;
            Children = new List<NaryNode<T>>();
        }

        internal void AddChild(NaryNode<T> childnode)
        {
            Children.Add(childnode);
        }

        public override string ToString()
        {
            return ToString("");
        }
        public string ToString(string spaces)
        {
            string result = spaces + Value + ":\n";

            foreach (NaryNode<T> node in Children)
            {
                if (node != null)
                {
                    result += node.ToString(spaces + "  ");
                }
            }

            return result;
        }
    }
}
