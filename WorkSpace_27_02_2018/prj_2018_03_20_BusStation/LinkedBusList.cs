using System;
using System.Collections.Generic;
using System.Text;

namespace prj_2018_03_20_BusStation
{
    class LinkedBusList : ILinkedBusList
    {
        public NodeBusList Head { get; set; }
        public NodeBusList Tail { get; set; }
        public void AddFirst(Bus bus)
        {
            NodeBusList node = new NodeBusList(bus);
            if (Head == null) { Head = node; Tail = Head; }
            else
            {
                node.Next = Head;
                Head = node;
            }
        }
        public void AddLast(Bus bus)
        {
            NodeBusList node = new NodeBusList(bus);
            if (Head == null) { Head = node; Tail = Head; }
            else
            {
                NodeBusList current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
        }
        public void AddAfterTail(Bus bus)
        {
            NodeBusList node = new NodeBusList(bus);
            if (Head == null) { Head = node; Tail = Head; }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
        }
        public void AddAfterTail(ref LinkedBusList buses)
        {
            if (Head == null) { Head = buses.Head; Tail = buses.Tail; }
            else
            {
                Head.Next = buses.Tail;
                Head = buses.Head;
            }
            buses.Head = null;
            buses.Tail = null;
        }
        public void Insert(int number, Bus bus)
        {
            NodeBusList node = new NodeBusList(bus);
            NodeBusList current = Head;
            while (current != null)
            {
                if (current.Info.Number == number)
                {
                    node.Next = current.Next;
                    current.Next = node;
                }
                current = current.Next;
            }
        }
        public Bus Find(int number)
        {
            NodeBusList current = Head;
            while (current != null)
            {
                if (current.Info.Number == number) return current.Info;
                current = current.Next;
            }
            return null;
        }
        public Bus Delete(int number)
        {

            NodeBusList current = Head;
            NodeBusList prev = null;
            while (current != null)
            {
                if (current.Info.Number == number)
                {
                    if (current == Head)
                    {
                        Head = Head.Next;
                        return current.Info;
                    }
                    if (current == Tail)
                    {
                        Tail = prev;
                        return current.Info;
                    }
                    prev.Next = current.Next;
                    return current.Info;
                }
                prev = current;
                current = current.Next;
            }
            return null;
        }
        public void Print()
        {
            NodeBusList current = Head;
            while (current != null)
            {
                Console.WriteLine(current.Info);
                current = current.Next;
            }
        }
    }
}
