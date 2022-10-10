// 27. Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

long input()
{
    Console.Write("Введите число: ");
    long number = Convert.ToInt64(Console.ReadLine());
    return number;
}

int sumDigit(long num)
{
    long result = 0;
    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return Convert.ToInt32(result); 
}

Console.WriteLine(sumDigit(input()));