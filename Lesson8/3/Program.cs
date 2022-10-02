//Задача 3-8
//Сформируйте двухмерный массив из неповторяющихся двузначных чисел (размер массива не более 50 элементов). 
//Напишите программу, которая будет построчно выводить массив.
//Вариант создания функции:
//Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
//Пример:
//Массив размером 3 x 3
//10 11 55
//33 41 23
//17 28 34


int strsCount = 5;
int columnsCount = 5;

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

void CreateArray(int[,] Array)
{
  int[] temp = new int[Array.GetLength(0) * Array.GetLength(1)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 99);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 99);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < Array.GetLength(0); x++)
  {
    for (int y = 0; y < Array.GetLength(1); y++)
    {
      
        Array[x, y] = temp[count];
        count++;
    }
    }
  }


int [,] Array = new int [strsCount, columnsCount];
CreateArray(Array);
PrintArray(Array);
Console.WriteLine(); 
