//Задача 1-7:Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными (тип double) числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.WriteLine("Введите необходимое количество строк: " );
int strsCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите необходимое количество столбцов: " );
int columnsCount = Convert.ToInt32(Console.ReadLine());

double [,] twoDimArray = new double [strsCount, columnsCount];
Random rand = new Random();

for (int i = 0; i < strsCount; i++)
{
    for (int j = 0; j < columnsCount; j++)
    {
        twoDimArray [i, j] = rand.NextDouble()*100;
        Console.Write("{0,6:F2}", twoDimArray[i, j]);
    }
  Console.WriteLine();
}
