// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using static System.Console;
Clear();
Write("Enter rows and column: ");
string[] parameter = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array = GetArray(int.Parse(parameter[0]), int.Parse(parameter[1]));
PrintArray(array);
SumColumn(array);

int[,] GetArray(int rows, int column)
{
    int[,] array = new int[rows,column];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < column; j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
    return(array);
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
    WriteLine();
}

void SumColumn(int[,] inArray)
{
    int[] column = new int[inArray.GetLength(1)];
    int index = 0;
    int sum = 0;
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i,j];
        }
        column[i] = sum;
        sum = 0;
    }
    int result = column[0];
    for(int k = 1; k < column.Length; k++)
    {
        if(result > column[k])
        {
            result = column[k];
            index = k;
        }
    }
    WriteLine($"Строка {index + 1} с наименьшей суммой элементов");
}
