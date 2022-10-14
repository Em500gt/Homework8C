//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
using static System.Console;
Clear();
Write("Enter rows and column: ");
string[] parameter = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array = GetArray(int.Parse(parameter[0]), int.Parse(parameter[1]));
PrintArray(array);
PrintArray(SortRevers(array));

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

int[,] SortRevers(int[,] inArray)
{
    int temp = 0;
    for(int i = 0; i < inArray.GetLength(0); i++)
    {   for(int j = 0; j < inArray.GetLength(1); j++)
        {   for(int k = 0; k < inArray.GetLength(1); k++)
            {
               if(inArray[i,j] > inArray[i,k])
                {
                    temp = inArray[i,j];
                    inArray[i,j] = inArray[i,k];
                    inArray[i,k] = temp;
                }
            }
        }
    }
    return inArray;
}
