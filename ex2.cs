Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max_num = num1;
if (max_num < num2)
{
    max_num = num2;
}
if (max_num < num3)
{
    max_num = num3;
}

Console.WriteLine("Наибольшее число: " + max_num);
