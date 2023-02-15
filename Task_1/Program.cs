/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) & result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Некорректные данные. Повторите ввод!");
        }
    }
    return result;
}

string GetLineOfNumbersFirstMethod(int N) //первый метод 
{
    if (N > 0) 
        return $"{N} " + GetLineOfNumbersFirstMethod(N-1);
    else 
        return String.Empty;
}

void GetLineOfNumbersSecondMethod(int N)
{
    if (N > 0)
    {
        Console.Write($"{N} ");
        N--;
        GetLineOfNumbersSecondMethod(N);
    }
}

int N = GetNumber("Введите число:");
Console.WriteLine(GetLineOfNumbersFirstMethod(N));
Console.WriteLine();
GetLineOfNumbersSecondMethod(N);
