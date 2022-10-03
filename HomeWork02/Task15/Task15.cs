// 15. Напишите метод, который принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void isWeekend(int num)
{
    if (num == 6 || num == 7)
    {
        Console.WriteLine("Выходной день");
    }
    else if (num > 0 && num < 6)
    {
        Console.WriteLine("Будний день");
    }
    else
    {
        Console.WriteLine("Неверный формат данных");
    }
}

Console.Write("Введите цифру, обозначающую день недели: ");
int day = int.Parse(Console.ReadLine());

isWeekend(day);