using System;

namespace Univer
{
    class Group
    {
        Student[] groupStudent;
        public Group()
        {
            Student stud1 = new Student("Vasya", 1, 4);
            //stud1.Sesiya();
            //stud1.print();

            groupStudent = new Student[5];
            groupStudent[0] = new Student("Tasya", 1, 6);
            groupStudent[1] = new Student("Dasya", 2, 3);
            groupStudent[2] = stud1;
            groupStudent[3] = new Student("Gasya", 2, 3);
            groupStudent[4] = new Student("Petya", 1, 5);
        }
        public Group(int numStudents)
        {
            groupStudent = new Student[numStudents];
        }
        public void Set(int i, Student student)
        {
            groupStudent[i] = student;
        }
        public void Sessiya()
        {
            for (int i = 0; i < groupStudent.Length; i++)
            {
                groupStudent[i].Sesiya();
            }
        }
        public void Print()
        {
            Console.WriteLine("-------------------------");
            for (int i = 0; i < groupStudent.Length; i++)
            {
                groupStudent[i].print();
            }
        }
        public void SortByNumGroup()
        {
            for (int i = 0; i < groupStudent.Length; i++)
            {
                for (int j = 0; j < groupStudent.Length - 1 - i; j++)
                {
                    if (groupStudent[j].NumGroup > groupStudent[j + 1].NumGroup)
                    {
                        Student temp = groupStudent[j];
                        groupStudent[j] = groupStudent[j + 1];
                        groupStudent[j + 1] = temp;
                    }
                }
            }
        }
        public void SortByAverage()
        {
            for (int i = 0; i < groupStudent.Length; i++)
            {
                for (int j = 0; j < groupStudent.Length - 1 - i; j++)
                {
                    if (groupStudent[j].Marks.Average > groupStudent[j + 1].Marks.Average)
                    {
                        Student temp = groupStudent[j];
                        groupStudent[j] = groupStudent[j + 1];
                        groupStudent[j + 1] = temp;
                    }
                }
            }
        }
        public double Average()
        {
            double sum = 0;
            for (int i = 0; i < groupStudent.Length; i++)
            {
                sum += groupStudent[i].Average();
            }
            return sum / groupStudent.Length;
        }
        public void PrintStudentWithMoney()
        {
            Console.WriteLine("-------- With Money -----------------");
            bool hasMoney = false;
            for (int i = 0; i < groupStudent.Length; i++)
            {
                if (groupStudent[i].Average() > 4) { groupStudent[i].print(); hasMoney = true; }
            }
            if (!hasMoney) { Console.WriteLine("No students has money"); }
        }
    }
}
