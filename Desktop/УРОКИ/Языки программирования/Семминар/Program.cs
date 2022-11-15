/*Console.Write ("Good morning!");*/

/*int number = 11;
Console.WriteLine ("Доброе утро! Сегодня " + "ноября");
Console.Write ($"Доброе утро! Сегодня {number} ноября");*/

/*Задача 1. Напишите программу, котрая на вход принимает число и выдает его квадрат
Console.WriteLine("Введите число квадрат которого нужно найти: ");
int number = Convert.ToInt32 (Console.ReadLine());
int result = number * number;
Console.WriteLine ($"Квадрат {number}равен {result}");*/

/*Задача 2.Напишите программу, котрая на вход принимает два числа и проверяет является ли первое число квадратом второго*/
//а=25, b =5 yes
//a=2, b=10 no
//a=9, b=-3 yes
//a=-3, b=9 no

/*Console.WriteLine ("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2*number2 == number1)
{
    Console.WriteLine($"число {number1} является квадратом {number2} ");
}
else
{
    Console.WriteLine($"Число {number1} не является квадратом {number2} ");
}
*/
/*Задача 3. Напишите программу которая на вход принимает одно число (N),а на выход показывает все целые числа в промежутке от -N до N*/
/*Console.WriteLine ("Введите N: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = num *(-1);
while ( current<= num )
{
    Console.Write (current + " ");
    current++;
}

Задача 4. Напишите программу которая принимает на входе трехзначное число и на выходе показывает последнюю цифру этого числа*/

Console.Write ("Введите трехзначное число: ");
int number = Convert.ToInt32 (Console.ReadLine());
if (number>99&&number<1000){
   int current = number%10;
    Console.WriteLine($"Последняя цифра числа {number} - {current}");
}
else 
{
   Console.WriteLine ("Число не трехзначное!");
}

