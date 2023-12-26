using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DataStructure;

namespace Node_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Node<int> n1 = new Node<int>(10);
            //Node<int> n2 = new Node<int>(20, n1);
            //Node<int> n3 = new Node<int>(30, n2);

            Node<char> n1 = new Node<char>('a');
            Node<char> n2 = new Node<char>('b', n1);
            Node<char> n3 = new Node<char>('c', n2);

            //Console.WriteLine(evenNumbers(n3));
            Console.WriteLine(isTheCharInTheList(n3,'x'));


        }
        public static void PrintNodes(Node<int> list)
        {
            Node<int> p = list;

            while(p != null)
            {
                Console.WriteLine(p.GetValue());
                p = p.GetNext();
            }

            Console.WriteLine(list);
            Console.WriteLine("new "+p);
        }
        public static int numOfObjects(Node<int> list)
        {
            Node<int> p = list;
            int counter = 0;
            while(p != null)
            {
                counter++;
                p = p.GetNext();
            }
            return counter;
        }
        public static int minValue(Node<int> node)//בהנחה שהרשימה מלאה
        {
            Node<int> p = node;
            int min = p.GetValue();
            p = p.GetNext();
            while (p.GetNext() != null)
            {
                p = p.GetNext();
                if (p.GetValue() < min)
                {
                   min = p.GetValue();
                }
                
            }
            return min;
        }
        public static int evenNumbers(Node<int> list)
        {
            Node<int> p = list;
            int evenNum = 0;
            while (p != null)
            {
                if (p.GetValue() % 2 == 0)
                {
                    evenNum++;
                }
                p = p.GetNext();
            }
            return evenNum;
        }


        public static bool isTheCharInTheList(Node<char> list, char c)
        {
            Node<char> p = list;
    
            while (p != null)
            {
                if (p.GetValue() == c)
                {
                    return true;
                }
                p = p.GetNext();

            }
            return false;
        }
    }
}
