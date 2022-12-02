// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int [] CreateRandomArray (int size)
{
    int [] newArray = new int [size];
    for (int i=0; i<size; i++)
    newArray [i] = new Random().Next (100,1000);
    return newArray;
}

void ShowArray (int [] array)
{
    for (int i=0; i<array.Length; i++)
    Console.Write (array[i] + " ");
    Console.WriteLine();
}

int CountOfNum (int []array)
{
    int count=0;
    for (int i=0; i<array.Length; i++)
         if (array[i]%2==0)
         {
            count++;
         }
         return count;
}
Console.Write ("Задайте количество элементов массива: ");
int count_of_elem = Convert.ToInt32(Console.ReadLine());
int []array1= CreateRandomArray (count_of_elem);
ShowArray(array1);
CountOfNum(array1);
Console.WriteLine($"Количество четных чисел в массиве {CountOfNum(array1)} ");
*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
int [] CreateRandomArray (int size)
{
    int [] newArray = new int [size];
    for (int i=0; i<size; i++)
    newArray [i] = new Random().Next (1,10);
    return newArray;
}

void ShowArray (int [] array)
{
    for (int i=0; i<array.Length; i++)
    Console.Write (array[i] + " ");
    Console.WriteLine();
}

int FindSumElem (int []array)
{
    int sum=0;
    for (int i=0; i<array.Length; i++)
         if (i%2!=0)
             sum+=array[i];
         return sum;
}
Console.Write ("Задайте количество элементов массива: ");
int count_of_elem = Convert.ToInt32(Console.ReadLine());
int []array1= CreateRandomArray (count_of_elem);
ShowArray(array1);
FindSumElem(array1);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве {FindSumElem(array1)} ");
*/
//________________________________________
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*
Console.WriteLine("Задайте размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}

Console.WriteLine($"Итого {numbers.Length} числа. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("   ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("  ");
    Console.WriteLine();
}
*/
double [] CreateRandomArray (int size)
{
    double [] newArray = new double [size];
    for (int i=0; i<size; i++)
    newArray [i] = Math.Round(new Random().Next(1,10)+new Random().NextDouble(), 3);
    return newArray;
}

void ShowArray (double [] array)
{
    for (int i=0; i<array.Length; i++)
    Console.Write (array[i] + " ");
    Console.WriteLine();
}

double CountOfNum (double []array)
{
    double count=0;
    double min=array[0];
    double max=array[0];
    for (int i=0; i<array.Length; i++)
    {
         if (array[i]>max)
            max=array[i];
         if (array[i]<min)
            min=array[i];
            count=max-min;
    }
    return count;
}
Console.Write ("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double []array1= CreateRandomArray (size);
ShowArray(array1);
double Num = CountOfNum(array1);
Console.WriteLine($"Разница между максимальным и минимальным элементами равна {Num} ");