// Задача 54: Задайте двумерный массив. Напишите программу, которая 
//упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
/*
int [,] Create2dArray (int row, int column,int minVal, int maxVal)
{
    int [,] created2dArray = new int [row, column];
    for (int i=0; i<row; i++)
         for (int j=0; j<column; j++)
         created2dArray[i,j] = new Random().Next(minVal, maxVal+1);
         return created2dArray;
}

void Show2dArray (int [,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortArray (int [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1)-1; j++)
        {
            for (int k=0; k<array.GetLength(1)-1; k++)
            {
                if (array[i,k]<array [i,k+1])
                {
                    int temp=0;
                    temp=array[i,k];
                    array[i,k]=array [i,k+1];
                    array [i,k+1] =temp;
                }
            }
         }
      }
    }

int [,] array2d =Create2dArray(3,4,2,5);
Show2dArray(array2d);
SortArray(array2d);
Console.WriteLine();
Show2dArray(array2d);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите 
//программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер 
//строки с наименьшей суммой элементов: 1 строка

//1 способ (через метод)
/*
int [,] Create2dArray (int row, int column,int minVal, int maxVal)
{
    int [,] created2dArray = new int [row, column];
    for (int i=0; i<row; i++)
         for (int j=0; j<column; j++)
         created2dArray[i,j] = new Random().Next(minVal, maxVal+1);
         return created2dArray;
}

void Show2dArray (int [,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SumStringArray (int [,] array)
{
    int index=0; int minSum=0;
    for (int i=0; i<array.GetLength(0); i++)
        {
            int sum=0;
            for (int j=0; j<array.GetLength(1); j++)
            {
                sum+=array [i,j];
            }
            Console.WriteLine ($"Сумма {i+1} строки = {sum}");
            if (i==0)
            {
                minSum=sum;
            }
            else if (sum<minSum)
            {
                minSum=sum;
                index=i;
            }
        }
        Console.WriteLine ($"Строка с минимальной суммой элементов: {index+1}");
  }
*/
//2 способ (без метода)
/*
Console.WriteLine("Задайте количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] array;
array = new int[rows, columns];
Random rnd = new Random();

for (int i = 0; i < rows; i++)
for (int j = 0; j < columns; j++)
array[i,j] = rnd.Next(0, 9);

for (int i = 0; i < rows; i++, Console.WriteLine())
for (int j = 0; j < columns; j++)
Console.Write(array [i, j] + " ");

int index=0;
int minSum=0;
for ( int i=0; i<rows; i++)
{
    int sum=0;
    for (int j=0; j<columns; j++)
    sum+= array[i,j];
   
    if(i==0)
    {
        minSum=sum;
    }
    else if(sum<minSum)
    {
        minSum=sum;
        index=i;
    }
}

Console.WriteLine ($"Строка с минимальной суммой элементов:{index+1}");

*/
 
//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

Console.Write ("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array2d = new int[rows, columns];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= rows * columns)
{
    array2d[i, j] = temp;
    if (i <= j + 1 && i + j < columns - 1)
        ++j;
    else if (i < j && i + j >= rows - 1)
        ++i;
    else if (i >= j && i + j > columns - 1)
        --j;
    else
        --i;
    ++temp;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();       
    }
    Console.WriteLine();
}
ShowArray(array2d);

