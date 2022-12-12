# Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

def enter(point):
    x, y = int(input('Введите коордитату x: ')), int(input('Введите коордитату y: '))
    print(f'{point}({x}, {y})')
    return [x, y]

def find_interval(a, b):
    result = ((a[0] - b[0]) ** 2 + (a[1] - b[1]) ** 2) ** 0.5
    print(round(result, 4))

point_a = enter('A')
point_b = enter('B')
find_interval(point_a, point_b)