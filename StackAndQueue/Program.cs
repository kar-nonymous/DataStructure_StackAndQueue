using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            stack.IsEmpty();
            stack.Enqueue(56);
            stack.Enqueue(30);
            stack.Enqueue(70);
            stack.DisplayQueue();
        }
    }
}
