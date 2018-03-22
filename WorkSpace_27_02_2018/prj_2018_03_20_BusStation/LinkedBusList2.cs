using System;
using System.Collections.Generic;
using System.Text;

namespace prj_2018_03_20_BusStation
{
    class LinkedBusList2 : ILinkedBusList
    {
        LinkedList<Bus> list;

        public NodeBusList Head { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public NodeBusList Tail { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddAfterTail(Bus bus)
        {
            throw new NotImplementedException();
        }

        public void AddAfterTail(ref LinkedBusList buses)
        {
            throw new NotImplementedException();
        }

        public void AddFirst(Bus bus)
        {
            throw new NotImplementedException();
        }

        public void AddLast(Bus bus)
        {
            throw new NotImplementedException();
        }

        public Bus Delete(int number)
        {
            foreach (var item in list)
            {
                if (item.Number == number)
                {
                    list.Remove(item);
                    return item;
                }
            }
            return null;
        }

        public Bus Find(int number)
        {
            foreach (var item in list)
            {
                if (item.Number == number)
                {
                    return item;
                }
            }
            return null;
        }

        public void Insert(int number, Bus bus)
        {
            foreach (var item in list)
            {
                if (item.Number == number)
                {
                    /// list.AddAfter(list, bus)
                }
            }
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}
