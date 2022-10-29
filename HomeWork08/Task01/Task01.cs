// 1. Есть число N. Скольно групп M, можно получить при разбиении всех чисел на группы, так чтобы в одной группе все числа были взаимно просты.

int InputNum()
{
    Console.Write("Введите N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}


int[,] Main(int[,] arr, int num)
{
    arr[0, 0] = 1;
    for (int k = 2; k <= num; k++)
    {
        for (int l = 1; l < arr.GetLength(0); l++)
        {
            bool flag = false;
            for (int m = 0; m < arr.GetLength(1); m++)
            { 
                if (arr[l, m] == 0) 
                {
                    arr[l, m] = k;
                    flag = true;
                    break;
                }
                else if (k % arr[l, m] == 0) break;
            }
            if (flag) break;
        }
    }
    return arr;
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i, 0] == 0) break;
        else Console.Write($"Группа {i + 1}: ");
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0)
            {
                break;
            }
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int number = InputNum();
int[,] emptyArray = new int[20, 500];    // Задать размерность массива
Console.WriteLine($"N = {number}");
Print(Main(emptyArray, number));