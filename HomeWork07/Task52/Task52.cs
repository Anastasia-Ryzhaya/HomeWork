// 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] FillArray()
{
    int[,] array = new int[6,6];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);    
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int n = 0; n < arr.GetLength(0); n++)
    {
        for (int m = 0; m < arr.GetLength(1); m++)
        {
            Console.Write($"{arr[n, m]} "); 
        }
        Console.WriteLine();
    }
}

double[] AverageColumns(int[,] myArray)
{
    double[] averageArray = new double[myArray.GetLength(1)]; // массив для складывания значений
    int index = 0;

    for (int k = 0; k < myArray.GetLength(1); k++)
    {
        double total = 0;
        for (int l = 0; l < myArray.GetLength(0); l++)
        {
            total += myArray[l, k];
        }
        averageArray[index] = total / myArray.GetLength(1);
        index++;
    }
    return averageArray;
}

void PrintNewArray(double[] newArr)
{
    for (int ind = 0; ind < newArr.Length; ind++)
    {
        Console.Write($"{newArr[ind]:F2} ");
    }
}

int[,] matrix = FillArray();
PrintArray(matrix);
Console.WriteLine();
PrintNewArray(AverageColumns(matrix));