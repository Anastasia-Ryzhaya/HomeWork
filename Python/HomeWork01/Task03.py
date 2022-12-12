# Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

def enter():
    x, y = int(input('Введите коордитату x: ')), int(input('Введите коордитату y: '))
    print(f'({x}, {y})')
    return [x, y]

def find_coord_quart(coord):
    if coord[0] > 0:
        if coord[1] > 0:
            print('1 четверть')
        else:
            print('4 четверть')
    else:
        if coord[1] < 0:
            print('3 четверть')
        else:
            print('2 четверть')

find_coord_quart(enter())