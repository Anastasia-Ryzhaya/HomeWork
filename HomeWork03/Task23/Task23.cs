// 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int input()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

void tabSqrt(int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index}^2 = {Math.Pow(index, 2)}");
        index++;
    }
}

tabSqrt(input());