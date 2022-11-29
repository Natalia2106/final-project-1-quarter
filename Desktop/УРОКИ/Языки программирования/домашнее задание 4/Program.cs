/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

/*
void Degreenum (int A, int B)
{
int result=A;
for (int i=1; i<B; i++)
    {
        result=result*A;
    }
    Console.WriteLine ($"число {A} в степени {B} равно {result}");
}
Console.WriteLine ("Введите число А: ");
int numberA=Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите число B: ");
int numberB=Convert.ToInt32 (Console.ReadLine());

if (numberA>=1 && numberB>=1)
{
    Console.Write ($"Натуральное ");
Degreenum(numberA, numberB);
}
else Console.WriteLine ("Не натуральное число,введите другое число!");

/*Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12


void MetFindSum (int num)
{
    int sum=0;
    while (num>0)
    {
        sum=sum+num%10;
        num/=10;
    }
 Console.WriteLine ($"Сумма всех цифр в числе равна {sum} ");
}
Console.WriteLine ("Введите число: ");
int user_num=Convert.ToInt32 (Console.ReadLine ());

MetFindSum (user_num);*/

/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов
 и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int [] LocalNewArray (int size)
{
    int [] array = new int [size];
    for (int i=0; i<size; i++)
    array [i] = new Random ().Next (0,10);
    return array;
}
void ShowArray (int []array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write (array [i]+ " ");
    }
}
Console.Write ("Input count of elements: ");
int count_of_elem=Convert.ToInt32 (Console.ReadLine ());
int []array1=LocalNewArray (count_of_elem);
ShowArray (array1);


