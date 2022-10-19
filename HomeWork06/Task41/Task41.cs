// 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

string Input()
{
    Console.WriteLine("Введите несколько чисел через запятую");
    string numbers = Console.ReadLine();
    return numbers;
}

int[] ConvertToNum(string text)
{
    string[] arr = text.Split(',');
    int[] arrNum = new int[arr.Length];
    for (int k = 0; k < arrNum.Length; k++)
    {
        arrNum[k] = Convert.ToInt32(arr[k]);
    }
    return arrNum;
}

int Count(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}

Console.WriteLine($"Введено чисел больше нуля: {Count(ConvertToNum(Input()))}");
