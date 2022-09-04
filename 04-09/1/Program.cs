//Задача 1
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Число хранить в типе данных int, решать с помощью арифметических операций (не рассматривая число как тип данных string)
//14212 -> нет
//12821 -> да
//23432 -> да
//**

Console.Write("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if ((N >= 10000) && (N < 100000))
{
    int digit_first = N / 10000;
    int digit_second = (N - digit_first * 10000 - N % 1000) / 1000;
    int digit_third = (N - digit_first * 10000 - digit_second * 1000) / 100;
    int digit_fourth = (N - digit_first * 10000 - digit_second * 1000 - digit_third * 100) / 10;
    int digit_last = N % 10;

    if ((digit_first == digit_last) && (digit_second == digit_fourth))
    {
        Console.WriteLine ("Введенное число " + N + " является палиндромом");
    }
    else 
    {
        Console.WriteLine ("Введенное число " + N + " НЕ является палиндромом");
    }
}
else
{
    Console.WriteLine("Ошибка! Введите ПЯТИЗНАЧНОЕ число!");
} 