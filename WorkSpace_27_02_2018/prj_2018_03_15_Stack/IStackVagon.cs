namespace RailWay
{
    public interface IStackVagon
    {
        bool IsEmpty { get; }
        bool IsFull { get; }

        Vagon Peek();
        Vagon Pop();
        void Print();
        void Push(Vagon v);
        void RaiseCapasity();
    }
}