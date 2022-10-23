// 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] array = {{13, 23, 33, 43, 53},
                { 1,  3,  6,  8,  9},
                {45, 84, 24,  7, 73},
                {90, 21, 49, 15, 10}};

(int, int) Input()
{
    Console.Write("Введите номер строки: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int y = Convert.ToInt32(Console.ReadLine());
    return (x, y);
}

(int row, int col) = Input();

int FindElement(int[,] arr, int r, int c)
{
    if (r < arr.GetLength(0) && r >= 0)
        if (c < arr.GetLength(1) && c >= 0)
            return arr[r, c];
        else return -1;
    else return -1;
}

void Print(int num)
{
    if (num == -1) Console.WriteLine("Выход за пределы массива!");
    else Console.WriteLine($"В заданной позиции находится число {num}");
}

Print(FindElement(array, row, col));