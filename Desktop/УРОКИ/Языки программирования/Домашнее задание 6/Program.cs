//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
/*
int []CreatNewArray (int size)
{
    int [] newArray = new int [size];
    for (int i=0; i<size; i++)
    //newArray[i]= new Random().Next(1,10);
    {
        Console.Write ($"Введите элементы {i+1} в массиве: ");
        newArray[i]=Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void ShowArray (int []array)
{
    for (int i=0; i<array.Length; i++)
    Console.Write (array[i]+ " ");
    Console.WriteLine();
}

int CountOfNum (int []array)
{
    int count=0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]>0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine ("Введите размер массива: ");
int size=Convert.ToInt32 (Console.ReadLine());
int [] createArray = CreatNewArray (size);
ShowArray(createArray);
int Num = CountOfNum(createArray);
Console.WriteLine ($" Количество чисел больше 0 равно {Num}");


*/
//Задача 43: Напишите программу, которая найдёт точку пересечения двух
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write ("Введите значение b1: ");
double b1=Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите значение k1: ");
double k1=Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите значение b2: ");
double b2=Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите значение k2: ");
double k2=Convert.ToInt32 (Console.ReadLine());

if (k1==k2)
Console.Write ("Прямые паралельны");
else
{
double x = (b2-b1)/(k1-k2);
double y= (k2*x+b2);
Console.WriteLine ($"Точка пересечения 2х прямых имеет координаты (Х:{x}, Y:{y})");
}

 



