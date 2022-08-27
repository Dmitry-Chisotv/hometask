//Задача 2: Напишите программу, которая выводит третью цифру случайно сгенерированного числа (от 1 до 65536) или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int rand = new Random (). Next(1, 65536);
Console.WriteLine (rand);
if (rand < 99)
{
    Console.WriteLine ("третьей цифры нет");
}

if (rand < 999)
{
    if (99 < rand)
    {
        int digit_last = rand % 10;
    Console.WriteLine (digit_last);
    }
}

if (rand < 9999)
{
    if (999 < rand)
    {
        int digit_first = rand / 100;
        int digit_last = rand % 10;
        int digit_second = rand - digit_first * 100 - digit_last;
        Console.WriteLine (digit_second / 10);
    }
}

if (rand < 65536)
{
    if (9999 < rand)
    {
        int digit_1 = rand / 1000;
        int digit_2 = (rand - digit_1*1000) / 100;
    Console.WriteLine (digit_2);
    }
}
