//Задача 1: Напишите программу, которая принимает на вход случайно сгенерированное трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1


int rand = new Random (). Next(100, 1000);
Console.WriteLine (rand);
int rand1 = rand / 10;
int digit_second = rand1 % 10;
Console.WriteLine (digit_second);