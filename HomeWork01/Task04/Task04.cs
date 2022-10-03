// 4. Найти максимальное из трех чисел

int inputRequest()
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int findMax(int num1, int num2, int num3)
{
    int max = num1;
    if (num2 > max) 
    {
        max = num2;
    }
    if (num3 > max)
    {
        max = num3;
    }
    return max;
}

Console.WriteLine("Требуется ввести три числа.");

int a = inputRequest();
int b = inputRequest();
int c = inputRequest();

Console.WriteLine($"Максимальное число: {findMax(a, b, c)}");

