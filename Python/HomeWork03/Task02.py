# Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

from random import randint
from math import ceil

def fill_list():
    count_of_elem = randint(5, 10)
    my_list = [randint(1, 9) for _ in range(count_of_elem)]
    return my_list

def main(list):
    result = [list[i] * list[-(i + 1)] for i in range(ceil(len(list) / 2))]
    print(list)
    print(result)

main(fill_list())