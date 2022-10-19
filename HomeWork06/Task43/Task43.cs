// 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.
// Значения b1, k1, b2 и k2 задаются пользователем.

double Input(string text)
{
    Console.Write($"Введите {text}: ");
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}

void FindPoint(double a1, double b1, double a2, double b2)
{
    if (a1 == a2 && b1 == b2) 
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if (a1 == a2)
    {
        Console.WriteLine("Точки пересечения отсутствуют");
    }
    else
    {
        double x = (b2 - b1) / (a1 - a2);
        double y = a1 * x + b1;
        Console.WriteLine($"Точка пересечения [{x}, {y}]");
    }
}

double k1 = Input("k1");
double b1 = Input("b1");
double k2 = Input("k2");
double b2 = Input("b2");

FindPoint(k1, b1, k2, b2);
