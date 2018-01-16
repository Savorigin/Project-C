using System;

namespace prj_2017_12_21_Array_N
{
    class Program
    {
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void MaxMas(int[] arr, out int myMax, out int iMax)
        {
            myMax = arr[0];
            iMax = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (myMax < arr[i])
                {
                    myMax = arr[i];
                    iMax = i;
                }
            }
        }
        static void PreTask()
        {
            int[,] matrix = new int[3, 4] {
                                            { 1, 2, 3, 4 },
                                            { 5, 5, 5, 5 },
                                            { 6, 7, 7, 9 }
                                            };
            Console.WriteLine(matrix.Length);
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            PrintMatrix(matrix);
            int sum = 0;
            int allsum = 0;
            int[] masSumRow = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // ====== befor processing all elem of i-row
                sum = 0;
                // =========================================
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // ----- processing j-elem i-row
                    sum += matrix[i, j];
                    // -----------------------------
                }
                // ====== after processing all elem of i-row
                Console.WriteLine($"matrix sum {i}-row = {sum}");
                masSumRow[i] = sum;
                allsum += sum;
                // =========================================
            }
            Console.WriteLine($"matrix allsum = {allsum}");
            int myMax, iMax;
            MaxMas(masSumRow, out myMax, out iMax);
            Console.WriteLine($"matrix myMax = {myMax}, iMax = {iMax}");
            /*int[][][] m2 = new int[2][][];
            m2[0] = new int[3][];
            m2[0][0] = new int[4];
            m2[0][0][0] = 777;*/
        }
        static void PrintPosMatrix(int[,] matrix)
        {
            Console.WriteLine("Positive elements");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0) Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void PrintMatrixZero(int[,] matrix)
        {
            int countZero = 0;
            bool isZero = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                isZero = false;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        isZero = true;
                        break;
                    }
                }
                if (isZero) countZero++;
            }
            Console.WriteLine("countZero = " + countZero);
        }
        static void PrintMatrixWithoutZero(int[,] matrix)
        {
            int countWithousZero = 0;
            bool isZero = false;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                isZero = false;
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    if (matrix[i, j] == 0)
                    {
                        isZero = true;
                        break;
                    }
                }
                if (!isZero) countWithousZero++;
            }
            Console.WriteLine("countWithousZero = " + countWithousZero);
        }
        static void PrintCountPosRow(int[,] matrix)
        {
            int count = 0;
            bool isPos = false;
            int[] posMas = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                isPos = false;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        isPos = true;
                    }
                }
                if (isPos)
                {
                    posMas[count] = i;
                    count++;
                }
            }
            Console.WriteLine("coumt pos row = " + count);
            for (int i = 0; i < posMas.Length; i++)
            {
                Console.Write(posMas[i] + " ");
            }
            Console.WriteLine();
        }
        static void SortMatrix(out int[,] matrix)
        {
            Console.WriteLine();
        }
        static void MaxLineRow(int[,] matrix)
        {
            int prev = 0;
            int max = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                prev = matrix[i, 0];
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    if (prev == matrix[i, j]) { }
                }
            }
        }
        /// <summary>
        /// Двумерные массивы  
        /// Дана целочисленная прямоугольная матрица. 
        /// 1. Вывести все положительные елементы;
        /// 2. Вывести количество строк, не содержащих ни одного нулевого элемента;
        /// 3. Вывести номера столбцов, содержащих хотя бы один нулевой элемент;
        /// 4. Вывести количество строк и номера строк в которых есть отрицательные елементы.
        /// 5. Вывести максимальное из чисел, встречающихся в заданной матрице более одного раза. 
        /// 6. Вывести номер строки, в которой находится самая длинная серия одинаковых элементов. 
        /// 7. Характеристикой строки целочисленной матрицы назовем сумму ее положительных четных элементов. 
        /// Переставляя строки заданной матрицы, расположить их в соответствии с ростом характеристик. 
        /// </summary>
        static void Task1()
        {
            int[,] matrix = new int[3, 4] {
                                            { 1, -2, 3, -4 },
                                            { -5, 0, 5, 5 },
                                            { -6, 7, 7, 9 }
                                            };
            PrintMatrix(matrix);
            PrintPosMatrix(matrix);
            PrintMatrixZero(matrix);
            PrintMatrixWithoutZero(matrix);
            PrintCountPosRow(matrix);
        }
        static void Main(string[] args)
        {
            //PreTask();
            Task1();
        }
    }
}
