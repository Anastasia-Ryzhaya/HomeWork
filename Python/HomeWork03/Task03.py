# Задайте список из вещественных чисел. 
# Напишите программу, которая найдёт разницу между максимальным и минимальным значением дробной части элементов.

from random import randint, uniform

def fill_list():
    count_of_elem = randint(1, 9)
    my_list = [round(uniform(0, 5), 4) for _ in range(count_of_elem)]
    return my_list

def main(list):
    new_list = [i % 1 for i in list]
    result = round(max(new_list) - min(new_list), 4)
    print(list)
    print(result)

main(fill_list())
