/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да


Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num1 = number / 10000;
int num2 = number / 1000 % 10;
int num4 = (number % 100) / 10;
int num5 = (number % 100) % 10;
void isPalindrome (int number)
{
  if (num1==num5 && num2==num4)
  {
    Console.WriteLine($"Your number: {number} is palindrome!");
  }
  else Console.WriteLine($"Your number: {number} - is not palindrome!");
}

if (number > 9999 && number < 100000)
{
  isPalindrome(number);
}
else Console.WriteLine($"Введи верное число");

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double LongLine (int x1, int y1, int z1, int x2, int y2, int z2)
{
    int x=x2-x1;
    int y=y2-y1;
    int z=z2-z1;
    double IengthAB = Math.Round(Math.Sqrt(x*x+y*y+z*z), 2);
    return IengthAB;   
}
Console.WriteLine ("input X coordinat of A: ");
int xA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("input Y coordinat of A: ");
int yA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("input Z coordinat of A: ");
int zA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("input X coordinat of B: ");
int xB = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("input Y coordinat of B: ");
int yB = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("input Z coordinat of B: ");
int zB = Convert.ToInt32 (Console.ReadLine());

double dist = LongLine (xA, yA, zA, xB, yB, zB);
Console.WriteLine ($"Distance AB is {dist} ");


/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт 
таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

void Qube (int num)
{
    int current = 1;
    while (current <=num)
    {
        int res = current*current*current;
        Console.Write ($"{res}, ");
        current++;
    }
    Console.WriteLine ($"\b\b. ");
}

Console.WriteLine ("Input number: ");
int number = Convert.ToInt32 (Console.ReadLine());
if (number>=1)
{
    Console.Write ($"{number} -> ");
    Qube (number);
}
else Console.WriteLine ("Imposible number! ");*/