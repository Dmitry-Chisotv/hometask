//Задача 1-8
//Задайте двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Номер строки с наименьшей суммой элементов: 1 строка
//(допускается указывать индекс строки в массиве, в данном примере - 0)

Console.WriteLine("Введите необходимое количество строк: " );
int strsCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите необходимое количество столбцов: " );
int columnsCount = Convert.ToInt32(Console.ReadLine());

int i1 = 0; // Переменная для цикла while
int j1 = 0; // Переменная для цикла while

Random rand = new Random();

void PrintArray(int [,] Array)
{
  for (int i = 0; i < Array.GetLength(0); i ++)
  {
    for (int j = 0; j < Array.GetLength(1); j ++)
    {
      Console.Write($"{Array [i, j]} ");
    }
    Console.WriteLine();   
  }
}

void FillArray (int [,] Array)
{
  for (int i = 0; i < strsCount; i++)
  {
    for (int j = 0; j < columnsCount; j++)
    {
        Array [i, j] = rand.Next(0,5);
    }
  }
}

int [,] Array = new int [strsCount, columnsCount];
FillArray(Array);
PrintArray(Array);
Console.WriteLine(); 

int sum_min = 500;
int i_min = 0;

for (i1 = 0; i1 < strsCount; i1++)
{
  int sum = 0;
  j1 = 0;
  while (j1 <columnsCount)
    {
        sum += Array [i1, j1];
        j1++;
    }
    //Console.Write (sum + "\t");
    if(sum < sum_min)
    {
        sum_min = sum;
        i_min = i1+1;
    }

}

Console.Write($"Номер строки с наименьшей суммой элементов: {i_min} строка, сумма составляет {sum_min}");