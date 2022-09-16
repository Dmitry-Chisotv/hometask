//Задача 2-7. Напишите программу, которая на вход принимает позиции (две) элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

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
        Array [i, j] = rand.Next(1,100);
    }
  }
}

int [,] Array = new int [strsCount, columnsCount];
FillArray(Array);
PrintArray(Array);
Console.WriteLine(); 

Console.WriteLine("Введите значение, которое необходимо найти в массиве: " );
int findDigital = Convert.ToInt32(Console.ReadLine());

for (j1 = 0; j1 <columnsCount; j1++)
{
 
    for (i1 = 0; i1 < strsCount; i1++)
    {
        if (findDigital == Array [i1, j1])
        {
          int findDigital1 =  Array [i1, j1];
          Console.Write("Значение " + findDigital1 + " встречается в данном массиве");
        }
    }
     
} 
Console.Write("Искомого числа " + findDigital + " в массиве нет");   

