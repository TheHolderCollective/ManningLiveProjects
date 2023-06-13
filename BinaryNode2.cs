using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_node2
{
    internal class BinaryNode<T>
    {
        internal T Value { get; set; }
        internal BinaryNode<T> LeftChild;
        internal BinaryNode<T> RightChild;

        internal BinaryNode(T value)
        {

            Value = value;
            LeftChild = null;
            RightChild = null;
        }

        internal void AddLeft(BinaryNode<T> leftvalue)
        {
            LeftChild = leftvalue;
        }

        internal void AddRight(BinaryNode<T> rightvalue)
        {
            RightChild = rightvalue;
        }
        public override string ToString()
        {
            return ToString("");
        }

        public string ToString(string spaces)
        {
            string result = spaces + Value + ":\n";

            if ((LeftChild != null) || (RightChild != null))
            {
                if (LeftChild != null)
                {
                    result += LeftChild.ToString(spaces + "  ");
                }
                else
                {
                    result += "  " + spaces + "None" + ":\n";
                }

                if (RightChild != null)
                {
                    result += RightChild.ToString(spaces + "  ");
                }
                else
                {
                    result += "  " + spaces + "None" + ":\n";
                }
            }
            return result;

        }

    }

}
