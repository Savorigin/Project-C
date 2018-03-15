using System;
using System.Collections;

namespace RailWay
{
    class Program
    {

        static void Main(string[] args)
        {
            IStackVagon train = new StackVagon1();
            /*train.Push(new Vagon { Type = 1 });
            train.Push(new Vagon { Type = 0 });
            train.Push(new Vagon { Type = 1 });
            train.Push(new Vagon { Type = 0 });
            train.Push(new Vagon { Type = 1 });
            train.Push(new Vagon { Type = 0 });
            train.Push(new Vagon { Type = 0 });
            train.Push(new Vagon { Type = 0 });*/
            //train = new TrainFactory().GetStackVagonFromFile(@"d:\Temp\train.txt");
            train = new TrainFactory().GetRandStackVagon(20);
            train.Print();
            IStackVagon cargo = new StackVagon();
            IStackVagon pass = new StackVagon2();
            while (!train.IsEmpty)
            {
                if (train.Peek().Type == 1) pass.Push(train.Pop());
                else cargo.Push(train.Pop());
            }
            pass.Print();
            cargo.Print();
        }
    }
}
