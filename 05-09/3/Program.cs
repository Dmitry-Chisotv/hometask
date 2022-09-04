//Задача 3:*(Дополнительная, необязательная задача): 
//Назовём число «интересным» если  произведение его цифр делится на их сумму. Напишите программу, которая заполняет массив на N «интересных» случайных целых чисел. (Каждый эл-т массива должен быть сгенерирован случайно)


Console.Write("Введите число N: ");
int ar_n = Convert.ToInt32(Console.ReadLine());

int i = 0;
int count = 0;

while (count < ar_n) 
{
 int rand = new Random().Next(1, 999);
 int tmp = rand;
 int sum = 0;
 int product = 1;
   while (tmp > 0)
   {
     int n = tmp % 10;
     sum += n;
     product = product * n;
     tmp /= 10;
   }
 
 int [] interest_digits = new int [ar_n];
 int j = 1; 

 if (product % sum == 0)
 {
   if ( product != 0)
   {
    interest_digits [j] = rand;
    Console.Write(interest_digits [j] + ", ");
    count ++;
   }
 }
 i++;
}