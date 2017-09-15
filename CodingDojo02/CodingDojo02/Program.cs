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
                String[] move = new String[array.Length];
                //counter to check the number of items in the stack
                int counter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != null)
                    {
                        counter++;
                    }
                }
                if (this.array[0] == null)
                {
                    this.array[0] = color;
                }
                else if (this.array[0] != null)
                {
                    for (int i = counter; i >=0; i--)
                    {
                        array[i+1] = array[i];
                    }
                }

                array[0] = color;
                
                return true;
            }

            public Boolean Pop()
            {
                int counter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != null)
                    {
                    counter++;
                    }
                }

                if (array[0] != null)
                {
                    Console.WriteLine("Popping " + array[0]);
                    for (int i = 0; i < counter; i++)
                    {
                        array[i] = array[i + 1];
                    }
                    array[counter] = null;
                }
                else if (array[0] == null)
                {
                    Console.WriteLine("No items in the stack.");
                }

                return true;
            }

            public String Peek()
            {
                return "First element of the stack is - " + array[0];
            }

            public String View()
            {
                int counter = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != null)
                    {
                        counter++;
                    }
                }
                if (array[0] != null)
                {
                    Console.WriteLine("BEGINNING OF STACK");
                    for (int i = 0; i < counter; i++)
                    {
                        Console.WriteLine((i+1)+". " + array[i]);
                    }
                    return "END OF STACK.";
                }
                return "No items";
            }

            public Boolean Exit()
            {
                return false;
            }
        }


        static void Main(string[] args)
        {
            Stack theStack = new Stack();
            while (true)
            {
                Console.WriteLine("1. Push \n" +
                    "2. Pop \n" +
                    "3. Peek \n" +
                    "4. View the stack");

                switch (Console.ReadLine())
                {   //push to the stack
                    case "1":
                        Console.WriteLine("Enter a color to push to the stack:");
                        Color col = new Color(Console.ReadLine());
                        theStack.Push(col.Name);
                        //theStack.View();
                        break;
                    //pop the top of the stack
                    case "2":
                        theStack.Pop();
                        break;
                    //peek at the top of the stack
                    case "3":
                        Console.WriteLine(theStack.Peek());
                        break;
                    case "4":
                        Console.WriteLine(theStack.View());
                        break;
                    default:
                        break;
                }
               
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

