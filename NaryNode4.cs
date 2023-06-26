using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nary_node4
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

        public NaryNode<T> FindNode(T value)
        {
            if (Value.Equals(value))
            {
                return this;
            }
            else
            {
                foreach (NaryNode<T> node in Children)
                {
                    if (node.FindNode(value) != null)
                    {
                        return node;
                    }

                }
            }
            return null;
        }

        public string TraversePreOrder()
        {
            string result = this.Value + " ";

            foreach (NaryNode<T> node in Children)
            {
                if (node != null)
                {
                    result += node.TraversePreOrder();
                }
            }
            return result;
        }

        public string TraversePostOrder()
        {
            string result = "";

            foreach (NaryNode<T> node in Children)
            {
                if (node != null)
                {
                    result += node.TraversePostOrder() + " ";
                }
            }

            result += this.Value;

            return result;

        }

        public string TraverseBreadthFirst()
        {
            string result = "";
            NaryNode<T> node;
            Queue<NaryNode<T>> queue = new Queue<NaryNode<T>>();

            queue.Enqueue(this);

            while (queue.Count != 0)
            {
                node = queue.Dequeue();
                result += node.Value + " ";

                foreach (NaryNode<T> nd in node.Children)
                {
                    queue.Enqueue(nd);
                }
              
            }

            return result;
        }
    }
}
