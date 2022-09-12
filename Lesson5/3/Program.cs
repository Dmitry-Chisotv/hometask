// Задача 3*: Задайте массив натуральных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите число N, соответствующее размеру массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 0;
int digitsMax = 1;
int digitsMin = 1000;
int [] digits = new int [n];

while (i < n) 
{
 digits [i] = new Random().Next(0, 1000);
Console.WriteLine(digits [i] + ", " + i + ", " );
   if ( digitsMax < digits [i])
   {
     digitsMax = digits [i];
   }
   if ( digitsMin > digits [i])
   {
     digitsMin = digits [i];
   }
   i++;
}
int dif = digitsMax - digitsMin;
Console.Write(digitsMax + " " + digitsMin + " " + dif );