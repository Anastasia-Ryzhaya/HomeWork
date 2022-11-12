// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Input(string text)
{
    Console.WriteLine($"Введите число {text}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int m = Input("M");
int n = Input("N");

if (n < m)
{
    int num = n;
    n = m;
    m = num;
}

int FindSum(int min, int max, int sum)
{
    sum += min;
    if (min == max) return sum;
    else 
    {
        min++;
        return FindSum(min, max, sum);
    }
}
Console.WriteLine(FindSum(m, n, 0));