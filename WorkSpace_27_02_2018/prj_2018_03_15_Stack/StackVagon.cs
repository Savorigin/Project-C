using System;

namespace RailWay
{
    public class StackVagonException : Exception
    {
        public StackVagonException(string message) : base(message)
        {
        }
    }
    public class StackVagon : IStackVagon
    {
        private Vagon[] masVagon;
        private int top;
        public StackVagon() : this(5)
        {
        }
        public StackVagon(int n)
        {
            masVagon = new Vagon[n];
            top = -1;
        }
        public void Push(Vagon v)
        {
            if (IsFull) RaiseCapasity();
            masVagon[++top] = v;
        }
        public Vagon Pop()
        {
            if (!IsEmpty) return masVagon[top--];
            else throw new StackVagonException("Stack is Empty");
        }
        public Vagon Peek()
        {
            if (!IsEmpty) return masVagon[top];
            else throw new StackVagonException("Stack isEmpty");
        }
        public bool IsFull { get { return top == masVagon.Length - 1; } }
        public bool IsEmpty { get { return top == -1; } }
        public void RaiseCapasity()
        {
            Vagon[] temp = new Vagon[masVagon.Length * 2];
            Array.Copy(masVagon, temp, masVagon.Length);
            masVagon = temp;
        }
        public void Print()
        {
            Console.WriteLine("****************************");
            foreach (var item in masVagon)
            {
                if (item != null) Console.Write(item + ", ");
            }
            Console.WriteLine("\n****************************");
        }
    }
}
