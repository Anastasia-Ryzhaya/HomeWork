// 25. Опишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.

void input(out int a, out int b)
{
    Console.Write("Введите число: ");
    a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите степень: ");
    b = Convert.ToInt32(Console.ReadLine());
}

double exponentiation(double a, double b)
{
    double result = 1;
    for (int i = 0; i < Math.Abs(b); i++)
    {
        result *= a;
    }
    if (b >= 0) 
    {
        return result;
    }
    else 
    {
        return 1 / result;
    }   
}

int num1;
int num2;

input(out num1, out num2);

Console.WriteLine(exponentiation(num1, num2));
