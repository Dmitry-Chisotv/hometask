//Задача 2
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


Console.Write("Введите значение на оси координат x для точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение на оси координат y для точки А: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение на оси координат z для точки А: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение на оси координат x для точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение на оси координат y для точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение на оси координат z для точки B: ");
int zb = Convert.ToInt32(Console.ReadLine());

int x = xb - xa;
int y = yb - ya;
int z = zb - za;
int a = x * x + y * y + z * z;

double length = Math. Sqrt( a );

Console.WriteLine("Расстояние между точками А и В в 3D пространстве: " + length);
