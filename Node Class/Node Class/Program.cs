using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure;

namespace Node_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<int> n1 = new Node<int>(10);
            Node<int> n2 = new Node<int>(20, n1);
            Node<int> n3 = new Node<int>(30, n2);

            Console.WriteLine(e1(n3)); 
        }
        public static void PrintNodes(Node<int> node)
        {
            Node<int> newNode = node;

            while(newNode != null)
            {
                Console.WriteLine(newNode.GetValue());
                newNode = newNode.GetNext();
            }

            Console.WriteLine(node);
            Console.WriteLine("new "+newNode);
        }
        public static int e1(Node<int> node)
        {
            Node<int> node1 = node;
            int counter = 0;
            while(node1 != null)
            {
                counter++;
                node1 = node1.GetNext();
            }
            return counter;
        }
    }
}
