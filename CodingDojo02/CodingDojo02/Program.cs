using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo02
{
    class Program
    {
        public class Color
        {
            public string Name;

            public Color(string Name)
            {
                this.Name = Name;
            }

        }

        public class Stack
        {
            public String[] array;
            public Stack()
            {
                this.array = new String[10];
            }

            public Boolean Push(String color)
            {
                if (this.array[0] == null)
                {
                    this.array[0] = color;
                }
                else if (this.array[0] != null)
                {
                    for (int i = 1; i < array.Length; i++)
                    {
                        if (array[i] == null)
                        {
                            array[i] = array[0];
                        }
                    }
                }

                array[0] = color;
                
                return true;
            }

            public Boolean Pop()
            {
                return true;
            }

            public String Peek()
            {
                return array[0];
            }
        }


        static void Main(string[] args)
        {
            Stack theStack = new Stack();
            while (true)
            {
                
                Console.WriteLine("Enter a color to push to the stack:");
                Color col = new Color(Console.ReadLine());
                theStack.Push(col.Name);
                Console.WriteLine("Stack begin: ");
                for (int i = 0; i < theStack.array.Length; i++)
                {
                    Console.WriteLine(theStack.array[i]);
                }
                Console.WriteLine("Stack end.");
            }
            




        }

        public static String[] createStack()
        {
            String[] stack = new String[10];
            return stack;
        }

        public void push(String name)
        {
            
        }

    }
}

