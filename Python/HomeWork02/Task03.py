# Задайте список из n чисел последовательности (1+1/n)**n и выведите на экран их сумму.

def enter():
    number = int(input('Введите число: '))
    return number

def main(num):
    list = [round((1 + 1 / i) ** i, 4) for i in range(1, num + 1)]
    print(list)
    print(sum(list))

main(enter())