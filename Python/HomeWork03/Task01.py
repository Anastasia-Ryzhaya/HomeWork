# Задайте список из нескольких чисел. Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной позиции.

from random import randint

def fill_list():
    count_of_elem = randint(5, 10)
    my_list = [randint(1, 9) for _ in range(count_of_elem)]
    return my_list

def main(list):
    sum = 0
    for i in range(len(list)):
        if i % 2 != 0:
            sum += list[i]
    print(list)
    print(sum)

main(fill_list())