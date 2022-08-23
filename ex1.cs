Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max_num = num1;
if (max_num > num2)
{
}
else
{
    max_num = num2;
}
Console.WriteLine("Наибольшее число: " + max_num);