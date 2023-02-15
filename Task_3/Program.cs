/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

uint GetNumber(string message)
{
    uint result = 0;
    while(true)
    {
        Console.WriteLine(message);
        if (uint.TryParse(Console.ReadLine(), out result) & result >= 0)
            break;
        else
        {
            Console.WriteLine("Некорректные данные. Повторите ввод.");
        }    
    }
    return result;
}

uint AkkermanFunction(uint n,  uint m)
{
    if (n == 0)
        return m + 1;
    else if ((n != 0) && (m == 0))
        return AkkermanFunction(n - 1, 1);
    else
      return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
}


uint n = GetNumber("Введите первое число:");
uint m = GetNumber("Введите второе число:");

uint akkermanNumber = AkkermanFunction(n,m);
Console.WriteLine(akkermanNumber);