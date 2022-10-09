// 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

long inputNum()
{
    Console.Write("Введите число: ");
    return Convert.ToInt64(Console.ReadLine());
}

void isPalindrom(long number)
{
    long firstNumber = number;
    long result = 0;

    while (firstNumber > 0)
    {
        result = (result + firstNumber % 10) * 10;
        firstNumber /= 10;
    }
    result /= 10;

    if (result == number)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число НЕ является палиндромом");
    }
}

isPalindrom(inputNum());