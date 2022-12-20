# Напишите программу, которая принимает на вход число N и выдает набор произведений чисел от 1 до N.

def enter():
    number = int(input('Введите целое число: '))
    return number

def main(num):
    list = [1]
    for i in range(1, num + 1):
        list.append(i * list[i - 1])
    list.remove(1)
    print(list)

main(enter())