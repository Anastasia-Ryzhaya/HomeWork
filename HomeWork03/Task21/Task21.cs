// 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int input(string text)
{
    Console.Write($"{text}: ");
    return Convert.ToInt32(Console.ReadLine());
}

string printPoint(string text, int a, int b, int c)
{
    return $"{text}({a}, {b}, {c})";
}

double findDistans(int a1, int b1, int c1, int a2, int b2, int c2)
{
    double a = Math.Pow(a2-a1, 2);
    double b = Math.Pow(b2-b1, 2);
    double c = Math.Pow(c2-c1, 2);
    double result = Math.Sqrt(a + b + c);
    return result;
}

int x1 = input("x1");
int y1 = input("y1");
int z1 = input("z1");
int x2 = input("x2");
int y2 = input("y2");
int z2 = input("z2");

Console.WriteLine(printPoint("A", x1, y1, z1));
Console.WriteLine(printPoint("B", x2, y2, z2));

Console.WriteLine(findDistans(x1, y1, z1, x2, y2, z2));

