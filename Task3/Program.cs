// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
using static System.Console;
Clear();
Write("Введите значения первого массива n и m: ");
string[] massFirst = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
Write("Введите значения второго массива n и m: ");
string[] massSecond = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

if(int.Parse(massFirst[0]) == int.Parse(massSecond[1]))
    {
        int[,] arrayA = GetArray(int.Parse(massFirst[0]), int.Parse(massFirst[1]));
        int[,] arrayB = GetArray(int.Parse(massSecond[0]), int.Parse(massSecond[1]));
        PrintArray(arrayA);
        PrintArray(arrayB);
        int[,] arrayC = Matrix(arrayA, arrayB);
        PrintArray(arrayC);
    }
else
{
    Write("Такие матрицы нельзя перемножить, так как количество столбцов матрицы А не равно количеству строк матрицы В...");
        return;
}

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

int[,] Matrix(int[,] arrSecond, int[,] arrFirst)
{
    int[,] result = new int[arrSecond.GetLength(0), arrFirst.GetLength(1)];
    for(int i = 0; i < arrSecond.GetLength(0); i++)
    {
        for(int j = 0; j < arrFirst.GetLength(1); j++)
        {
            result[i,j] = 0;
            for(int k = 0; k < arrSecond.GetLength(1); k++)
            {
                result[i,j] += arrSecond[i,k] * arrFirst[k,j];
            }
        }
    }
    return result;
} 

