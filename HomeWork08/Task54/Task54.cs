// 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] FillArray()
{
    int [,] array = new int [10, 10];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 31);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int n = 0; n < arr.GetLength(1); n++)
        {
            Console.Write($"{arr[m, n]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Sorted(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            for (int h = 0; h < matrix.GetLength(1); h++)
            {
                if (matrix[k, h] < matrix[k, l])
                {
                    int num = matrix[k, h];
                    matrix[k, h] = matrix[k, l];
                    matrix[k, l] = num;
                }
            }
        }
    }
    return matrix;
}

int[,] myArray = FillArray();
PrintArray(myArray);
Console.WriteLine();
PrintArray(Sorted(myArray));