using System;

namespace Univer
{
    class Program
    {
        static void Main(string[] args)
        {
            Group k16 = new Group();
            k16.Sessiya();
            k16.Print();
            k16.SortByNumGroup();
            k16.Print();
            k16.PrintStudentWithMoney();

            /*Group k17 = new Group(2);
            k17.Set(0, new Student());
            k17.Set(1, new Student());
            k17.Print();*/

            Group[] faculty = new Group[2];
        }
    }
}
