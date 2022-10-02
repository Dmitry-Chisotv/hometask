//Задача 2-8
//Задайте две квадратные матрицы одного размера. 
//Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

using System;
using System.Linq;
using System.Collections.Generic;
 
namespace csharp_cmd
{
    class Program
    {
        public static int[,] mult(int[,] ar1, int[,] ar2)
        {
            int[,] m = new int[ar1.GetLength(0), ar2.GetLength(1)];
 
            for (int i = 0; i < ar1.GetLength(0); ++i)
                for (int j = 0; j < ar2.GetLength(0); ++j)
                    for (int k = 0; k < ar2.GetLength(1); ++k)
                        m[i, k] += ar1[i, j] * ar2[j, k];
            return m;
        }
 
        static void Test1()
        {
            int[,] ar1 = { {2, 4}, { 3, 2} };
            int[,] ar2 = { { 3, 4}, {3, 3 } };
 
            int[,] m = mult(ar1, ar2);
 
            for (int i = 0; i < ar1.GetLength(0); ++i)
            {
                for (int j = 0; j < ar2.GetLength(1); ++j)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
 
        static void Main()
        {
            Test1();
        }
    }
}
