using System;

namespace prj_2017_12_19_Array
{
    class Program
    {
        static void PreTask()
        {
            const int COUNT_ELEM = 10;
            //int[] mas = new int[COUNT_ELEM];
            //int[] arr = mas;
            //arr[2] = 8888;
            //mas[4] = 9;
            //int x = mas[5];
            //mas[5] = 7777;
            //Console.WriteLine("x = " + x.ToString());
            int[] mas = new int[COUNT_ELEM] { 1, 2, 3, 1, 2, 3, 1, 2, 3, 4 };
            for (int i = 0; i < mas.Length; i++)
            {
                //Console.WriteLine("mas[" + i + "] = " + mas[i]);
                //Console.WriteLine("mas[{0}] = {1}", i, mas[i]);
                //Console.WriteLine($"mas[{i}] = {mas[i]}");
                //Console.Write(mas[i] + ", ");
                //Console.Write(mas[i] + "\t");
                Console.Write(mas[i]);
                if (i != 9) Console.Write(", ");
            }
            Console.WriteLine();
            int sum = 0;
            int myMin = mas[0];
            int iMin = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (myMin > mas[i]) { myMin = mas[i]; iMin = i; }
                sum += mas[i];
            }
            Console.WriteLine("sum = " + sum);
            Console.WriteLine("average = " + (double)sum / mas.Length);
            Console.WriteLine("min = " + myMin + ", i = " + iMin);
            Console.WriteLine("\n---------------------------------------");
            foreach (var item in mas)
            //foreach (int value in mas)
            {
                Console.Write(item + ", ");
            }
        }
        static void WriteInConsole(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + ", ");
            }
            Console.Write("\n");
        }
        static int[] InitMas()
        {
            const int COUNT_ARRAY = 10;
            int[] arr = new int[COUNT_ARRAY];
            return arr;
        }
        static void EnterFirstMas(int[] arr)
        {
            int i = 0;
            int j = 1;
            while (i < arr.Length)
            {
                if (j % 2 != 0) { arr[i] = j; i++; }
                j++;
            }
        }
        static void TrimToSize(ref int[] arr, int iElem)
        {
            int[] tempMas = new int[iElem];
            for (int i = 0; i < iElem; i++)
            {
                tempMas[i] = arr[i];
            }
            arr = tempMas;
        }
        static void EraseCapasity(ref int[] mas)
        {
            int[] tempMas = new int[mas.Length * 2];
            for (int i = 0; i < mas.Length; i++)
            {
                tempMas[i] = mas[i];
            }
            mas = tempMas;
        }
        static void EnterTwoMas(out int[] arr0, out int[] arr1) // ref int[] arr1
        {
            arr0 = InitMas();
            arr1 = InitMas();
            Console.WriteLine("Enter 10 int value");
            int m0 = 0, m1 = 0;
            for (int i = 0; i < arr0.Length; i++)
            {
                int v = int.Parse(Console.ReadLine());
                if (v % 2 == 0) { arr0[m0] = v; m0++; }
                else { arr1[m1] = v; m1++; }
            }
            TrimToSize(ref arr0, m0);
            TrimToSize(ref arr1, m1);
        }
        static int SumElement(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }
        static double AverageElement(int[] arr)
        {
            return (double)SumElement(arr) / arr.Length;
        }
        /// <summary>
        /// 1.создайте массив, содержащий 10 первых нечетных чисел. Выведете элементы массива на консоль в одну строку, разделяя запятой
        /// </summary>
        static void Task1()
        {
            int[] mas = InitMas();
            EnterFirstMas(mas);
            WriteInConsole(mas);
        }
        /// <summary>
        /// 2.ввести 10 целых значений с консоли и разместить в 2 масива четные и нечетные
        /// </summary>
        static void Task2()
        {
            int[] mas0;
            //int[] mas1 = null;
            int[] mas1;
            EnterTwoMas(out mas0, out mas1); // ref mas1
            WriteInConsole(mas0);
            WriteInConsole(mas1);
        }
        /// <summary>
        /// 3.подсчитать сколько четные и нечетные
        /// </summary>
        static void Task3()
        {
            int[] mas0;
            int[] mas1;
            EnterTwoMas(out mas0, out mas1);
            WriteInConsole(mas0);
            WriteInConsole(mas1);
            Console.WriteLine("Count 1 = " + mas0.Length);
            Console.WriteLine("Count 2 = " + mas1.Length);
        }
        /// <summary>
        /// 4.сумма елементов в каждом масиве и среднее арифметическое
        /// </summary>
        static void Task4()
        {
            int[] mas0;
            int[] mas1;
            EnterTwoMas(out mas0, out mas1);
            WriteInConsole(mas0);
            WriteInConsole(mas1);
            Console.WriteLine("Sum 1 = " + SumElement(mas0));
            Console.WriteLine("Sum 2 = " + SumElement(mas1));
            Console.WriteLine("Average 1 = " + AverageElement(mas0));
            Console.WriteLine("Average 2 = " + AverageElement(mas1));
        }
        static void Task5()
        {
        }
        static void Task6()
        {
        }
        static void Task7()
        {
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter task 1-7");
            int t = int.Parse(Console.ReadLine());
            switch (t)
            {
                case 1: Task1(); break;
                case 2: Task2(); break;
                case 3: Task3(); break;
                case 4: Task4(); break;
                case 5: Task5(); break;
                case 6: Task6(); break;
                case 7: Task7(); break;
                default: PreTask(); break;
            }
        }
    }
}
