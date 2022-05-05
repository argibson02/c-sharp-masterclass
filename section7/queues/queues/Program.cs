using System;
using System.Collections.Generic;

namespace queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Queue<int> queue = new Queue<int>();

            // add
            queue.Enqueue(1);
            Console.WriteLine("peeked " + queue.Peek());
            queue.Enqueue(2);
            Console.WriteLine("peeked " + queue.Peek());
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            // peek. gets first in
            Console.WriteLine("peeked " + queue.Peek());

            // remove
            queue.Dequeue();
            Console.WriteLine("peeked " + queue.Peek());
            //queue.Dequeue();
            //Console.WriteLine("peeked " + queue.Peek());


            while (queue.Count > 0)
            {
                int dq = queue.Dequeue();
                Console.WriteLine($"The front value {dq} has been dequeued");

                if (queue.Count > 0)
                {
                    Console.WriteLine($"The next item is {queue.Peek()}");
                }
                else
                {
                    Console.WriteLine("The queue is now empty.");
                }
            }


            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!");

            Queue<Order> ordersQ = new Queue<Order>();

            foreach (Order o in ReceivedOrdersB1())
            {
                // add all orders to queue
                ordersQ.Enqueue(o);
            }
            foreach (Order o in ReceivedOrdersB2())
            {
                // add all orders to queue
                ordersQ.Enqueue(o);
            }

            while (ordersQ.Count > 0)
            {
                // dequeue will run even on assigment
                Order currentOrder= ordersQ.Dequeue();

                // inherits this function from the class
                currentOrder.ProcessOrder();
            }


            Console.Read();
        }


        static Order[] ReceivedOrdersB1()
        {
            Order[] orders = new Order[]
            {
                new Order(1, 215),
                new Order(2,3),
                new Order(8,23)
            };
            return orders;
        }

        static Order[] ReceivedOrdersB2()
        {
            Order[] orders = new Order[]
            {
                new Order(4, 5),
                new Order(5,365),
                new Order(82,7)
            };
            return orders;
        }


    }
}
