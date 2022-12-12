# Напишите программу для проверки истинности утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат.

def enter():
    numbers = [int(input('Введите число: ')) for _ in range(3)]
    return numbers

def check(num):
    result = not(num[0] or num[1] or num[2]) == (not num[0] and not num[1] and not num[2])
    print(result)

check(enter())
