# Задайте список из N элементов, заполненных числами из промежутка [-N, N]. 
# Найдите произведение элементов на указанных позициях. 
# Позиции хранятся в отдельном списке(пример n=4, lst1=[4,-2,1,3] - списко на основе n, а позиции элементов lst2=[3,1].

from random import randint

def enter():
    number = int(input('Введите целое число: '))
    return number

def main(num):
    list1 = [randint(-num, num) for i in range(num)]
    list2 = [randint(0, len(list1) - 1) for _ in range(2)]
    while list2[0] == list2[1]:
        list2[1] = randint(0, len(list1))
    print(list1)
    print(list2)
    print(list1[list2[0]] * list1[list2[1]])

main(enter())