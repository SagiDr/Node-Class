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

            //Node<int> n1 = new Node<int>(6);
            //Node<int> n2 = new Node<int>(6, n1);
            //Node<int> n3 = new Node<int>(30, n2);

            //Node<char> n1 = new Node<char>('a');
            //Node<char> n2 = new Node<char>('b', n1);
            //Node<char> n3 = new Node<char>('c', n2);

            //Console.WriteLine(evenNumbers(n3));
            //Console.WriteLine(isTheCharInTheList(n3,'x'));
            //Console.WriteLine(numCount(n3, 6));


            //Console.WriteLine("Original List:");
            //PrintNodes(n3);

            //int numToAdd = 2;
            //addNum(n3, numToAdd);

            //Console.WriteLine($"List after adding {numToAdd} to each element:");
            //PrintNodes(n3);



            //Node<double> n1 = new Node<double>(-2.5);
            //Node<double> n2 = new Node<double>(5.0, n1);
            //Node<double> n3 = new Node<double>(-8.3, n2);

            //turnNegative(n3);


            //Node<int> n1 = new Node<int>(1);
            //Node<int> n2 = new Node<int>(3, n1);
            //Node<int> n3 = new Node<int>(5, n2);

            //Console.WriteLine($"Is the list sorted in ascending order? {isItDorted(n3)}");



            //Node<int> n1 = new Node<int>(1);
            //Node<int> n2 = new Node<int>(2, n1);
            //Node<int> n3 = new Node<int>(3, n2);
            //Node<int> n4 = new Node<int>(4, n3);
            //Node<int> n5 = new Node<int>(5, n4);


            //int e = 4;
            //int s = 2;

            //Console.WriteLine($"Print range from {s} to {e}:");
            //PrintRange(n5, e, s);



            //Node<string> n1 = new Node<string>("Cat");
            //Node<string> n2 = new Node<string>("Dog", n1);
            //Node<string> n3 = new Node<string>("Chameleon", n2);
            //Node<string> n4 = new Node<string>("Elephant", n3);

            //Console.WriteLine("Cat names starting with 'C':");
            //PrintCatNamesStartingWithC(n4);

            Node<string> n1 = new Node<string>("Apple");
            Node<string> n2 = new Node<string>("Banana", n1);
            Node<string> n3 = new Node<string>("Cherry", n2);
            Node<string> n4 = new Node<string>("Orange", n3);

            char characterToFind = 'a';
            int count = CountStringsContainingChar(n4, characterToFind);

            Console.WriteLine($"Number of strings containing '{characterToFind}': {count}");


        }
        public static void PrintNodes(Node<int> list)
        {
            Node<int> p = list;

            while (p != null)
            {
                Console.WriteLine(p.GetValue());
                p = p.GetNext();
            }

            Console.WriteLine(list);
            Console.WriteLine("new " + p);
        }
        public static int numOfObjects(Node<int> list)
        {
            Node<int> p = list;
            int counter = 0;
            while (p != null)
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

        public static int numCount(Node<int> list, int num)
        {
            Node<int> p = list;
            int count = 0;
            while (p != null)
            {
                if (p.GetValue() == num)
                {
                    count++;

                }
                p = p.GetNext();
            }
            return count;
        }

        public static void addNum(Node<int> list, int num)
        {
            Node<int> p = list;

            while (p != null)
            {
                int currentValue = p.GetValue();
                p.SetValue(currentValue + num);

                p = p.GetNext();
            }
        }

        public static void turnNegative(Node<double> list)
        {
            Node<double> p = list;

            while (p != null)
            {
                double value = p.GetValue();

                if (value < 0)
                {
                    p.SetValue(Math.Abs(value));
                }
                p = p.GetNext();
            }
        }

        public static bool isItDorted(Node<int> list)
        {
            Node<int> current = list;

            while (current != null && current.GetNext() != null)
            {
                if (current.GetValue() > current.GetNext().GetValue())
                {
                    // If the current value is greater than the next value, the list is not sorted
                    return false;
                }

                current = current.GetNext();
            }


            // If the loop completes, the list is sorted in ascending order
            return true;
        }

        public static void PrintRange(Node<int> list, int e, int s)
        {
            // Assuming the list starts from 1
            int currentElement = 1;
            Node<int> current = list;

            // Advance to the starting position (s)
            while (currentElement < s && current != null)
            {
                currentElement++;
                current = current.GetNext();
            }

            // Print elements from s to e
            while (currentElement >= s && currentElement <= e && current != null)
            {
                Console.WriteLine(current.GetValue());
                currentElement++;
                current = current.GetNext();
            }
        }



        public static void PrintCatNamesStartingWithC(Node<string> list)
        {
            Node<string> current = list;

            while (current != null)
            {
                string name = current.GetValue();

                // Check if the name starts with 'C' (case-insensitive)
                if (name.StartsWith("C", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(name);
                }

                current = current.GetNext();
            }
        }


        public static int CountStringsContainingChar(Node<string> list, char character)
        {
            if (list == null)
            {
                // Handle the case of an empty list
                return 0;
            }

            Node<string> current = list;
            int count = 0;

            while (current != null)
            {
                string currentString = current.GetValue();

                // Check if the string contains the specified character
                if (currentString.Contains(character))
                {
                    count++;
                }

                current = current.GetNext();
            }

            return count;
        }



    }
}
