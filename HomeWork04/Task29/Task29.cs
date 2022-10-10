// 29. Напишите метод, который задаёт массив из 8 элементов и выводит их на экран.

int[] fillArray()
{
    int[] array = new int[8];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

string printArray(int[] mass)
{
    return String.Join(", ", mass);
}

Console.WriteLine($"[{printArray(fillArray())}]");