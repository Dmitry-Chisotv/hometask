//Задача 3: * Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Если кол-во элементов нечетное, то элемент посередине не учитывать.
//Результат сложения вывести на экран.
//1, 3, 8, 3, 2 -> 11
//8, 3, 4, 2 -> 28



Console.WriteLine("Введите число, соответствующее размеру массива");
int n = Convert.ToInt32(Console.ReadLine());
int index = 0; // Переменная для цикла while
int[] array = new int[n];
Random rand = new Random();
for (int i = 0; i < array.Length; i++) //переменая для цикла for объявляется в самом цикле.
{
array[i] = rand.Next(1, 9);

}
Console.WriteLine(string.Join(" ", array)); //простая форма вывода массива на печать.

int sum = 0;

while (index < array.Length/2)
{
int product = array[index] * array[array.Length - index-1];
Console.WriteLine(array [index] + ", " + array[array.Length - index-1]);
Console.WriteLine(product);
sum = sum + product;
index++;
}

Console.WriteLine(sum);
