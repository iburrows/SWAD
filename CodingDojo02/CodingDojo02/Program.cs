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

            //public string Name { get; set; }

        }

        public class Stack
        {
            public Stack()
            {
                
            }

            public Boolean Push()
            {
                return true;
            }

            public Boolean Pop()
            {
                return true;
            }

            public String Peek()
            {
                return "";
            }
        }


        static void Main(string[] args)
        {
            Stack theStack = new Stack();
            Console.WriteLine("Enter a color to push to the stack:");
            Color col = new Color(Console.ReadLine());
            



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

