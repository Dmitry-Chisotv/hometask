
// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму четных элементов, стоящих на нечётных позициях (позиция - индекс элемента в массиве).
//[3, 7, 23, 12] -> 12
//[4, 6, 8, 1, 4] -> 6

Console.Write("Введите число N, соответствующее размеру массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 0;
int sum = 0;
int [] digits = new int [n];

while (i < n) 
{
 digits [i] = new Random().Next(0, 1000);
//Console.WriteLine(digits [i] + ", " + i + ", " );
   if ((digits [i] %2 == 0) && (i %2 != 0))
   {
     sum += digits [i];
   }
   i++;
}
Console.Write( sum );
