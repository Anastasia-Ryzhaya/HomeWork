// 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// При наличии нескольких строк с одинаковым минимальным значением, программа выводит первую по счету строку с минимальным значением.

int[,] FillArray()
{
    int [,] array = new int [10, 5];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 21);
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

int RowMinSum(int[,] matrix)
{
    int minRow = 0;
    int minSum = 100;
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        int sum = 0;
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            sum += matrix[k, l];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minRow = k;
        }
    }
    return minRow + 1;
}

int[,] myArray = FillArray();
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine($"{RowMinSum(myArray)} строка");