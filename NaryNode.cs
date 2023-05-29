using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naray_node1
{
    internal class NaryNode<T>
    {
        internal T Value { get; set; }
        internal List<NaryNode<T>> Children;

        internal  NaryNode(T value)
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
            string result = string.Format("{0}: ", Value);

            foreach (NaryNode<T> node in Children)
            {
               result += string.Format("{0} ", node.Value);
            }

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NaryNode<string> NaryRoot = new NaryNode<string>("Root");

            // children of root node
            NaryNode<string> L1_Child1 = new NaryNode<string>("A");
            NaryNode<string> L1_Child2 = new NaryNode<string>("B");
            NaryNode<string> L1_Child3 = new NaryNode<string>("C");

            // children of child1 of root node
            NaryNode<string> L2_Child1_1 = new NaryNode<string>("D");
            NaryNode<string> L2_Child1_2 = new NaryNode<string>("E");

            // children of child3 of root node
            NaryNode<string> L2_Child3_1 = new NaryNode<string>("F");

            // children of child1 of child 1 of root node
            NaryNode<string> L3_Child1_1_1 = new NaryNode<string>("G");

            //children of child1 of child 3 of root node
            NaryNode<string> L3_Child3_1_1 = new NaryNode<string>("H");
            NaryNode<string> L3_Child3_1_2 = new NaryNode<string>("I");

            // add children to root node
            NaryRoot.AddChild(L1_Child1);
            NaryRoot.AddChild(L1_Child2);
            NaryRoot.AddChild(L1_Child3);

            // add children to child1 of root node
            L1_Child1.AddChild(L2_Child1_1);
            L1_Child1.AddChild(L2_Child1_2);

            // add children to child3 of root node
            L1_Child3.AddChild(L2_Child3_1);

            // add children to child1 of child 1 of root node
            L2_Child1_1.AddChild(L3_Child1_1_1);

            // add children to child1 of child 3 of root node
            L2_Child3_1.AddChild(L3_Child3_1_1);
            L2_Child3_1.AddChild(L3_Child3_1_2);



            Console.WriteLine(NaryRoot);
            Console.WriteLine(L1_Child1);
            Console.WriteLine(L1_Child2);
            Console.WriteLine(L1_Child3);
            Console.WriteLine(L2_Child1_1);
            Console.WriteLine(L2_Child1_2);
            Console.WriteLine(L2_Child3_1);
            Console.WriteLine(L3_Child1_1_1);
            Console.WriteLine(L3_Child3_1_1);
            Console.WriteLine(L3_Child3_1_2);

        }
    }
}
