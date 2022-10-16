// 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int numElem()
{
    Console.Write("Задайте количество элементов массива: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] fillAndPrintArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

int countOddPositions(int[] arr)
{
    int count = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        count += arr[i];
    }
    return count;
}

int[] result = fillAndPrintArray(numElem());
Console.WriteLine(countOddPositions(result));