// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] array = new int[4, 4, 4];

List<int> numbers = new List<int>();

int GetRandomNumber()
{
    int num = new Random().Next(10, 100);
    if (!numbers.Contains(num)) 
    {
        numbers.Add(num);
        return num;
    }
    else return GetRandomNumber();
}

int[,,] FillArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = GetRandomNumber();
            }
        }
    }
    return arr;
}

void PrintArray(int[,,] myArray)
{
    for (int l = 0; l < myArray.GetLength(0); l++)
    {
        for (int m = 0; m < myArray.GetLength(1); m++)
        {
            for (int n = 0; n < myArray.GetLength(2); n++)
            {
                Console.Write($"{myArray[l, m, n]}({l}, {m}, {n}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

PrintArray(FillArray(array));
