// 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] arr1 = {{1, 2, 3}, 
               {4, 5, 6}, 
               {7, 8, 9},
               {5, 5, 5}};

int[,] arr2 = {{2, 3, 1, 3}, 
               {2, 3, 5, 3}, 
               {4, 2, 3, 3}};

int[,] Matrix(int[,] x, int[,] y)
{
    int[,] matrix = new int[x.GetLength(0), y.GetLength(1)];
    for (int i = 0; i < x.GetLength(0); i++)
    {
        for (int j = 0; j < y.GetLength(1); j++)
        {
            for (int k = 0; k < x.GetLength(1); k++)
            {
                matrix[i, j] += x[i, k] * y[k, j];
            }
        }
    }
    return matrix;
}

void Print(int[,] mat)
{
    for (int n = 0; n < mat.GetLength(0); n++)
    {
        for (int m = 0; m < mat.GetLength(1); m++)
        {
            Console.Write($"{mat[n, m]} ");
        }
        Console.WriteLine();
    }
}

Print(Matrix(arr1, arr2));
