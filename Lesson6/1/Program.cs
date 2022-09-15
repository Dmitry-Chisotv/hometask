//Задача 1: Программа запрашивает натуральное число M, пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int MforConsumer = new Random().Next(1, 10);
int countM = 0;
int count = 0;
//Console.WriteLine(MforConsumer);
int tmp = MforConsumer;

while (countM < MforConsumer)
{
    Console.WriteLine("Введите " + tmp + " чисел");
    int n = Convert.ToInt32(Console.ReadLine());  
    if (n > 0)
    {
        count +=1;
    }
countM +=1;
tmp -= 1;
}

Console.WriteLine("Пользователем введено " + count + " положительных чисел");