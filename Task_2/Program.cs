/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) & result > 0)
            break;
        else
        {
            Console.WriteLine("Некорректные данные. Повторите ввод.");
        }    
    }
    return result;
}

int SumOfNumbers(int M, int N)
{
    if (M == N) return M;
    return M + SumOfNumbers(M + 1, N);
    
}
    
    /*int sum = 0;
    for (int i = M; i < N + 1; i++)
    {
        sum = sum + i;
    }
    return sum;*/


int M = GetNumber("Введите первое число:");
int N = GetNumber("Введите второе число:");

int s = SumOfNumbers(M, N);
Console.WriteLine(s);
