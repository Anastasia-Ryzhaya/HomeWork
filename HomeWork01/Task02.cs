// 2. Даны два числа. Показать большее и меньшее число

void compareNumbers(int a, int b)
{
    if (a > b)
    {
        Console.WriteLine($"Большее число: {a}\nМеньшее число: {b}");
    }
    else if (a < b)
    {
        Console.WriteLine($"Большее число: {b}\nМеньшее число: {a}");
    }
    else
    {
        Console.WriteLine($"Числа {a} и {b} равны");
    }
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

compareNumbers(number1, number2);