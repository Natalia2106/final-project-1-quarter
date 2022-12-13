// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
//для 5
/*
void ShowNumbers(int n)
{
    Console.Write(n+ " ");
    if (n>1) ShowNumbers (n-1);
}
ShowNumbers(5);
*/
//для 8
/*
void ShowNumbers(int n)
{
    Console.Write(n+ " ");
    if (n>1) ShowNumbers (n-1);
}
ShowNumbers(8);
*/
//Задача 66: Задайте значения M и N. Напишите программу, которая 
//найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
Console.WriteLine("Введите число М: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n=Convert.ToInt32(Console.ReadLine());

void SumDigits (int m, int n, int sum)
{
    if (m>n)
    {
       Console.WriteLine ($"Сумма натуральных элементов в промежутке от M до N: {sum}");
       return; 
    }
    sum=sum+(m++);
    SumDigits(m,n,sum);
}
    SumDigits(m,n,0);
*/

//Написать рекурсивную функцию перевода из десятичной системы 
//исчисления в двоичную

void DecToBin(int num)
{
    string binNum = string.Empty;
    
    if (num != 0)
    {
        if (num % 2 == 1)
            binNum += "1";
        else
            binNum += "0";
            DecToBin(num / 2);
    }
Console.Write(binNum);
}
Console.Write("Введите натуральное число: ");
int numDecimal = Convert.ToInt32(Console.ReadLine());
DecToBin(numDecimal);
