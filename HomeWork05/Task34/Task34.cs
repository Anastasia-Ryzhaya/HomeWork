// 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int numElem()
{
    Console.Write("Задайте количество элементов массива: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] fillAndPrintArray (int number)
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

int countEven(int[] arr)
{
    int count = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] myArray = fillAndPrintArray(numElem());
Console.WriteLine(countEven(myArray));