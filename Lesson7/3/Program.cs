//Задача 3-7. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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
        Array [i, j] = rand.Next(1,10);
    }
  }
}

int [,] Array = new int [strsCount, columnsCount];
FillArray(Array);
PrintArray(Array);
Console.WriteLine(); 

Console.Write("Среднее арифметическое каждого столбца: ");

for (j1 = 0; j1 <columnsCount; j1++)
{
  double sum = 0;
  double count = 0;
  
    for (i1 = 0; i1 < strsCount; i1++)
    {
        count += 1;
        sum += Array [i1, j1];
    }    
  double avr = sum/count;
  Console.Write(avr + "; ");
}
