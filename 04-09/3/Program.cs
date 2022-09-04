//Задача 3
//
//Напишите программу, которая принимает на вход число (N) и помещает в массив таблицу кубов чисел от 1 до N. Полученный массив вывести на экран.
//3 -> [1, 8, 27]
//5 -> [1, 8, 27, 64, 125]

//****

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int [] array = new int [N];

int index = 0;
int num = 1;
while (index < N)
{
    array [index] = num * num * num;
    Console.Write(array [index] + " ");
    num++;
    index++;
} 
