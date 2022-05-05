using System;
using System.Collections.Generic;

namespace stackAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // define new stack
            Stack<int> stack = new Stack<int>();

            // push to stack. add on top
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            // peek
            int peek = stack.Peek();
            Console.WriteLine(peek);

            // pop. cannot pop on empty stack 
            if (stack.Count > 0)
            {
                stack.Pop();
                Console.WriteLine(stack.Peek());
            }


            Console.WriteLine("~~~");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Peek());
                stack.Pop();
            }


            //reversing array
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            Stack<int> numStack = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                numStack.Push(numbers[i]);
            }
            while (numStack.Count > 0)
            {
                Console.Write(numStack.Peek() + " ");
                numStack.Pop();
            }

            Console.Read();
        }
    }
}
