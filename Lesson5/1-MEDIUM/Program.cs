﻿//Уровень MEDIUM
//Задача 1
//Реализовать алгоритм, который выводит на экран возрастающую
//последовательность случайных чисел от 1 до 1000. Как только сумма цифр
//очередного числа в последовательности достигнет 26, остановить генерацию,
//вывести на экран сообщение «Stop».
//Примеры
//5 9 50 69 255 899 Stop
//50 633 655 700 854 999 Stop



int ar_n = 1;
int i = 0;
int count = 0;

while (count < ar_n) 
{
 int rand = new Random().Next(1, 1000);
Console.Write(rand + ", ");
 int tmp = rand;
 int sum = 0;
 
   while (tmp > 0)
   {
     int n = tmp % 10;
     sum += n;
     tmp /= 10;
   }

 if ( sum >= 26)
 {
  
    Console.Write("Stop ");
    count ++;
 }
 }
 i++;
 
// не доделал увлеичение чисел, только рандомные