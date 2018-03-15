using System;
using System.Collections.Generic;
using System.Text;

namespace RailWay
{
    class StackVagon2 : Stack<Vagon>, IStackVagon
    {
        public bool IsEmpty => throw new NotImplementedException();

        public bool IsFull => throw new NotImplementedException();

        public void Print()
        {
            Console.WriteLine("+++++++++++++++++++++++++++");
            foreach (var item in this)
            {
                Console.Write(item + ": ");
            }
            Console.WriteLine("\n+++++++++++++++++++++++++++");
        }

        public void RaiseCapasity()
        {
            throw new NotImplementedException();
        }
    }
}
