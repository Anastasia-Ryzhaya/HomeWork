// 10. Напишите метод, который принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int secondDigit(int num)
{
    num = num / 10 % 10;
    return num;
}

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"Втарая цифра веденного числа: {secondDigit(number)}");