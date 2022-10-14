//  Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
using static System.Console;
Clear();
Write("Введите размер массива через пробел (M,N): ");

string[] parameter = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
string[,] arr = GetArray(int.Parse(parameter[0]),int.Parse(parameter[1]));
PrintArray(arr);

string[,] GetArray(int a, int b)
{   
    string[,] array = new string[a,b];
    string[] res = new string[a * b];
    int count = 0;
    int i = 0;
    int j = 0;
    for(int g = 0; g < res.GetLength(0); g++)
    {
        res[g] = g > 8? (g + 1).ToString() : "0" + (g + 1).ToString();
    }
    while(count != res.GetLength(0))
    {
        array[i,j] = res[count];
        count++; 
        if(i <= j + 1 && i + j < array.GetLength(1) - 1) j++;
        else if(i < j &&  i + j >= array.GetLength(0) - 1) i++;
        else if(i >= j && i + j > array.GetLength(1) - 1) j--;
        else i--;
    }
    return array;
}

void PrintArray(string[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}
