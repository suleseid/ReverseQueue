using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseQueue
{
    public class Queue
    {
        public void ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            // Pop elements from the queue and push onto the stack
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            // Pop elements from the stack and enqueue back into the queue
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }

    }
}
