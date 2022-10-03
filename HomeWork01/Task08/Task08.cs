// 8. Показать четные числа от 1 до N

void printEven(int num)
{
    for (int numEven = 2; numEven <= num; numEven += 2)
    {
        Console.WriteLine(numEven);
    }
}

Console.Write("Введите чило: ");
int number = int.Parse(Console.ReadLine());

printEven(number);