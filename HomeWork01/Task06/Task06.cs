//  6. Выяснить является ли число чётным

void isEven(int num)
{
    if (num % 2 == 0)
    {
        Console.WriteLine("Число четное");
    }
    else
    {
        Console.WriteLine("Число нечетное");
    }
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

isEven(number);

