// 13. Напишите метод, который выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void thirdDigit(int num)
{
    if (Math.Abs(num) < 100)
    {
        Console.WriteLine("Третья цифра отсутствует");
    }
    else
    {
        while (Math.Abs(num) > 999)
        {
            num /= 10;
        }
        Console.WriteLine($"Третья цифра цисла: {Math.Abs(num % 10)}");
    }
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

thirdDigit(number);