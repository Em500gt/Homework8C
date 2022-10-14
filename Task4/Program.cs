// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
using static System.Console;
Clear();
Write("Введите размер трёхмерного массива через пробел (M,N,X): ");

string[] parameter = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,,] arr = GetArray(int.Parse(parameter[0]),int.Parse(parameter[1]),int.Parse(parameter[2]));
PrintArray(arr);

int[,,] GetArray(int a, int b, int c)
{   
    Random rnd = new Random();
    int[,,] array = new int[a,b,c];
    int[] res = new int[a * b * c];
    int count = 0;
    for(int i = 0; i < res.GetLength(0); i++)
    {
        res[i] = rnd.Next(10,21);
        if(i > 0)
        {
            for(int j = 0; j < i; j++)
            {
                while(res[i] == res[j])
                {
                    res[i] = rnd.Next(10,21);
                    j = 0;
                }
            }
        }
    }
    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            for(int k = 0; k < c; k++)
            {
                array[i,j,k] = res[count++];
            }
        }
    }
    return array;
}

void PrintArray(int[,,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            for(int k = 0; k < inArray.GetLength(2); k++)
            {
                Write($"{inArray[i,j,k]} ({i},{j},{k}) ");
            }
            WriteLine();
        }
    }
}



