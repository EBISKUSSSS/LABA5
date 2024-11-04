using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyQueue<string> q1 = new MyQueue<string>();
            q1.Enqueue("I");
            q1.Enqueue("Love");
            q1.Enqueue("Pizza");
            q1.WriteInfo();
            q1.Dequeue();
            q1.WriteInfo();
            Console.WriteLine("Amount of elements: " + q1.Count);
            Console.WriteLine("First element is: " + q1.Peek());
        }
    }
    public class MyQueue<T> 
    {
        private Queue<T> queue;
        public MyQueue()
        {
          queue = new Queue<T>();
        }

        public void Enqueue(T item)
        {
            queue.Enqueue(item);
        }


        public T Dequeue()
        {
            T removeditem = queue.Dequeue();
            Console.WriteLine("Dequeueing element: " + removeditem);
            return removeditem;
        }

        public T Peek()
        {
            return queue.Peek();
        }

        public int Count
        {
            get {return queue.Count; }
        }

        public void WriteInfo()
        {
            Console.WriteLine("-------------------------------------");
           Console.WriteLine("Elements: ");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------");
        }
    }
}
