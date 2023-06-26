using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_node4
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
            //QueueofNodes = new Queue<BinaryNode<T>>;
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

        public BinaryNode<T> FindNode(T value)
        {
            if (Value.Equals(value))
            {
                return this;
            }
            else if ((LeftChild != null) && (LeftChild.FindNode(value) != null))
            {
                return LeftChild;
            }
            else if ((RightChild != null) && (RightChild.FindNode(value) != null))
            {
                return RightChild;
            }
            return null;
        }


        public string TraversePreOrder()
        {

            //this.result = this.Value + " ";

            string result = this.Value + " ";

            if (LeftChild != null)
            {
                result += LeftChild.TraversePreOrder();
            }
            if (RightChild != null)
            {
                result += RightChild.TraversePreOrder();
            }
            return result;
        }

        public string TraverseInOrder()
        {
            string result = "";

            if (LeftChild != null)
            {
                result += LeftChild.TraverseInOrder();
            }

            result += this.Value + " ";

            if (RightChild != null)
            {
                result += RightChild.TraverseInOrder();
            }
            return result; 

        }

        public string TraversePostOrder()
        {
            string result = "";

            if (LeftChild != null)
            {
                result += LeftChild.TraversePostOrder();
            }


            if (RightChild != null)
            {
                result += RightChild.TraversePostOrder();
            }

            result += this.Value + " ";

            return result;

        }

        public string TraverseBreadthFirst()
        {
            string result = "";
            BinaryNode<T> node;
            Queue<BinaryNode<T>> queue = new Queue<BinaryNode<T>>();

            queue.Enqueue(this);

            while(queue.Count != 0)
            {
                node = queue.Dequeue();
                result += node.Value + " ";

                if (node.LeftChild != null)
                {
                    queue.Enqueue(node.LeftChild);
                }
                if (node.RightChild != null)
                {
                    queue.Enqueue(node.RightChild);
                }
            }

            return result;

        }



    }
}
