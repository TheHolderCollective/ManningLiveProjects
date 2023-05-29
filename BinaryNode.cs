using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_node1
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
            string result;

            result = string.Format("{0}:" ,Value);

            if (LeftChild != null)
            {
                result += " " + LeftChild.Value;
            }
            else
            {
                result += " null";

            }

            if (RightChild != null)
            {
                result += " " + RightChild.Value;
            }
            else
            {
                result += " null";
            }

            return result;

        }
        
    }   
    class Binary
    {
        static void Main(string[] args)
        {
            BinaryNode<string> BinaryTreeRoot = new BinaryNode<string>("Root");

            // child nodes of root node
            BinaryNode<string> L1_LeftNode = new BinaryNode<string>("A");
            BinaryNode<string> L1_RightNode = new BinaryNode<string>("B");

            // left and right nodes of left node of root node
            BinaryNode<string> L2_L_LeftNode = new BinaryNode<string>("C");
            BinaryNode<string> L2_L_RightNode = new BinaryNode<string>("D");

            // right node of right child node of root node
            BinaryNode<string> L2_R_RightNode = new BinaryNode<string>("E");

            // left node of right child node of left child node of root node
            BinaryNode<string> L3_R_LeftNode = new BinaryNode<string>("F");

            //add children to root node
            BinaryTreeRoot.AddLeft(L1_LeftNode);
            BinaryTreeRoot.AddRight(L1_RightNode);

            // add children to left node of left node of root node
            L1_LeftNode.AddLeft(L2_L_LeftNode);
            L1_LeftNode.AddRight(L2_L_RightNode);

            // add right node to right node of root node
            L1_RightNode.AddRight(L2_R_RightNode);

            // add left node to right child node of root node
            L2_R_RightNode.AddRight(L3_R_LeftNode);


            Console.WriteLine(BinaryTreeRoot);
            Console.WriteLine(L1_LeftNode);
            Console.WriteLine(L1_RightNode);
            Console.WriteLine(L2_L_LeftNode);
            Console.WriteLine(L2_L_RightNode);
            Console.WriteLine(L2_R_RightNode);
            Console.WriteLine(L3_R_LeftNode);
        }
    }
}
