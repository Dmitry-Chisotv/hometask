// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Write("Введите число N, соответствующее размеру массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 0;
int countEven = 0;
int [] digits = new int [n];

while (i < n) 
{
 digits [i] = new Random().Next(100, 1000);
// Console.WriteLine(digits [i] + ", " + i + ", " );
   if (digits [i] %2 == 0)
   {
     countEven += 1;
   }
   i++;
}
Console.Write( countEven );
