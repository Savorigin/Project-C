namespace prj_2018_03_20_BusStation
{
    interface ILinkedBusList
    {
        NodeBusList Head { get; set; }
        NodeBusList Tail { get; set; }

        void AddAfterTail(Bus bus);
        void AddAfterTail(ref LinkedBusList buses);
        void AddFirst(Bus bus);
        void AddLast(Bus bus);
        Bus Delete(int number);
        Bus Find(int number);
        void Insert(int number, Bus bus);
        void Print();
    }
}