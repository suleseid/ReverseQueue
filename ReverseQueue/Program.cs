using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<int> originalQueue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });

            Queue queue = new Queue();
            queue.ReverseQueue(originalQueue);

            Console.WriteLine("New Order:");
            foreach (int item in originalQueue)
            {
                Console.Write(item + " ");
            }

        }
    }
}
