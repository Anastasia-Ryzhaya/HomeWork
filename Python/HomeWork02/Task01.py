# Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.

from math import fabs

def enter():
    number = input('Введите вещественное число: ')
    return number

def sum_of_digit(num):
    num = ''.join(num.split('.'))  # в качестве разделителя дробной части используется точка
    num = fabs(int(num))
    total = 0
    while num > 0:
        total += num % 10
        num //= 10
    print(int(total))

sum_of_digit(enter())