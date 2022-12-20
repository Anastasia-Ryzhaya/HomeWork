# Реализуйте алгоритм перемешивания списка.

from random import randint

def mixing():
    list = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
    lenght_list = len(list)
    for i in range(10):
        for j in range(lenght_list):
            random_num = randint(0, lenght_list - 1)
            list[j], list[random_num] = list[random_num], list[j]
    print(list)

mixing()

