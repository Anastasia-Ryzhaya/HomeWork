// 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int numElem()
{
    Console.Write("Задайте количество элементов массива: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double[] fillAndPrintArray(int number)
{
    double[] array = new double[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().Next(1, 100) * new Random().NextDouble(), 2);
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
    return array;
}

double diffMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int j = 1; j < arr.Length; j++)
    {
        if (arr[j] > max)
        {
            max = arr[j];
        }
        else if (arr[j] < min)
        {
            min = arr[j];
        }
    }
    return Math.Round(max - min, 2);
}

double[] result = fillAndPrintArray(numElem());
Console.WriteLine(diffMaxMin(result));