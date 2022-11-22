/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

Console.Write ("Введите трехзначное число: ");
int number = Convert.ToInt32 (Console.ReadLine());
if (number>99 && number<1000)
{
    int current = number%100/10;
    Console.WriteLine ($"Число {current} является второй цифрой этого числа");
}
else 
{
    Console.WriteLine ("Число не трехзначное!");
}
*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
1 решение
Console.Write ("Введите число ");
int number =Convert.ToInt32 (Console.ReadLine ());
if (number>99 && number<1000)
{
    int current =number%10;
    Console.WriteLine ($"Третьей цифрой числа {number} является {current}");
}
if (number>9999 && number<100000)
{
    int current =number%1000/100;
    Console.WriteLine ($"Третьей цифрой числа {number} является {current}");
}
else if (number<100)
{
    Console.WriteLine ($"Третьей цифры нет");
}
/*
2. Решение методом
int ThirdNum(int number)
{
   if(number < 100 )
    {
        Console.WriteLine("Третьей цифры нет");
    }
    if (number >= 100 && number <= 1000)
    {
        int number_third = number % 10;
        Console.WriteLine("Третья цифра данного числа: " + number_third);
    }
    if (number >= 1000) 
    {
        while (number >= 1000)
        {
          int new_num = number / 10; 
          number = new_num;
        }

        int number_third = number % 10;
        Console.WriteLine("Третья цифра этого числа: " + number_third);
    }
    return number;
 }
Console.WriteLine("Введите число: ");
int new_num = Convert.ToInt32(Console.ReadLine());
int res = ThirdNum(new_num);
/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

Console.WriteLine ("Введите цифру, обозначающую день недели ");
int number = Convert.ToInt32(Console.ReadLine ());
if (number>=1 && number <=5)
{
    Console.WriteLine ("Это не выходной!");
}
if (number >=6 && number<=7)
{
    Console.WriteLine ("Да, это выходной!");
}
*/