# Задайте число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов.

def enter():
    number = int(input('Введите число: '))
    return number

def fibonacci(num):
    list1 = [0, 1]
    for i in range(num - 1):
        list1.append(list1[i] + list1[i + 1])
    list2 = []
    for j in range(len(list1)):
        if j % 2 == 0:
            list2.append(-(list1[j]))
        else:
            list2.append(list1[j])
    for k in range(1, len(list2)):
        list1.insert(0, list2[k])
    print(list1)

fibonacci(enter())