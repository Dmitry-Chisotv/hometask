//Уровень MEDIUM
//Задача 2
//Михаил интересуется созданием простых чисел. Его интересуют
//простые числа с некоторыми характеристиками:
//+ число сгенерировано случайным образом;
//+ его квадрат не оканчивается на 1;
//• сумма его цифр лежит в диапазоне от 10 до 20
//+Сгенерировать пять простых чисел, удовлетворяющих пожеланиям
//+Михаила, и вывести их на экран.
//Пример: 97 397 83 317 383

using System;
namespace Prime
{
    class Program
    {
        public static bool IsPrime(int number) 
        { 
            for (int i = 2; i < number; i++) 
            { 
                if (number % i == 0) 
                    return false; 
            } 
            return true; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество простых чисел которые необходимо найти: N =");
            if ((!int.TryParse(Console.ReadLine(), out int result))||(result<=0))
            Console.WriteLine($"Значение {result} должно быть положительным ");
            int count = 0; //количество найденных простых чисел
            int number = 1; //очередное число, проверку которого необходимо найти
            int total = 0; //общее количество проверенных чисел
            while (count < result)
            {
                total++;
                number++;
                int rand = new Random().Next(1, 1000);

                int last = (rand*rand) % 10;

                int tmp = rand;
                int sum = 0;
 
                while (tmp > 0)
                {
                    int n = tmp % 10;
                    sum += n;
                    tmp /= 10;
                }
                //Console.WriteLine(sum);

                if (IsPrime(rand) && last != 1 && sum >= 10 && sum <= 20)
                {
                    Console.Write($"{rand} ");
                    //Console.WriteLine(sum);
                    //Console.Write(rand + " " + rand*rand + "   " + last);
                    count++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"Найдено {count} простых чисел для Михаила. Проверено {total} чисел");
        }
    }
}