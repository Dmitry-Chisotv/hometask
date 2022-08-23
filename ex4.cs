Console.Write("Введите число N: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int i = new Random(). Next(1, num1+1);
i = 2;

while (i < num1+1)
{
    if (i %2 == 0)
    Console.Write(i + ", ");
    i = i + 1;
}
