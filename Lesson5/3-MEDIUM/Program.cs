//Уровень MEDIUM
//Задача 3
//Под подъемом в массиве будем понимать его подпоследовательность из
//двух и более элементов, которая не убывает. Подъем заканчивается, если
//встретился элемент, меньший предыдущего или достигнут конец массива.
//Например, arr = [1 2 6 2 0], его подъем – [1 2 6]. Подъемы [1 2], [2 6] внутри этой подпоследовательности [1 2 6] не учитываем.
//Другой пример, arr = [1 2 6 2 0 5 9 12 47 47 2], его подъемы – [1 2 6], [0 5 9 12 47 47].
//Сгенерировать массив из N случайных натуральных чисел. Определить, сколько в нем подъемов.

Console.Write("Введите число N, соответствующее длинне массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] rand = new int [n];
int i = 2;
int count = 0;

while (i < n) 
{
 rand [i] = new Random().Next(1, 999);
 Console.Write( rand [i] + ", " );
 if (rand [i] < rand [i-1] && rand [i-1] > rand [i-2])
 {
      count ++;
 }
 i++;
 }
Console.WriteLine(count); 