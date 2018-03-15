using System;
using System.Collections;

namespace RailWay
{
    class StackVagon1 : IStackVagon
    {
        Stack stack;
        public StackVagon1()
        {
            stack = new Stack();
        }
        public bool IsEmpty { get { return stack.Count == 0; } }

        public bool IsFull { get { return stack.Count == 0; } }

        public Vagon Peek()
        {
            return stack.Peek() as Vagon;
        }

        public Vagon Pop()
        {
            return stack.Pop() as Vagon;
        }

        public void Print()
        {
            Console.WriteLine("---------------------------");
            foreach (var item in stack)
            {
                Console.Write(item + ": ");
            }
            Console.WriteLine("\n---------------------------");
        }

        public void Push(Vagon v)
        {
            stack.Push(v);
        }

        public void RaiseCapasity()
        {
            throw new NotImplementedException();
        }
    }
}
