//Задача 1: 
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать функцию Math.Pow()
//3, 5 -> 243
//2, 4 -> 16

Console.Write("Введите число А: ");
int digit_A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В, в степень которого необходимо ввести число А: ");
int digit_B = Convert.ToInt32(Console.ReadLine());

int index = 1;
int digit_ab = 1;
while (index <= digit_B)
{
    digit_ab = digit_ab * digit_A;
    index++;
} 

Console.WriteLine("А в степени В = " + digit_ab);
