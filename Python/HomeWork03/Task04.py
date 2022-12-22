# Напишите программу, которая будет преобразовывать десятичное число в двоичное.

def enter():
    number = int(input('Введите число: '))
    return number

def main(num):
    binary_num_list = []
    while num > 0:
        digit = str(num % 2)
        binary_num_list.insert(0, digit)
        num //= 2
    binary_num = int(''.join(binary_num_list))
    print(binary_num)

main(enter())