//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n

static uint Akk(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}

Console.WriteLine(Akk(1, 2)); 
Console.WriteLine(Akk(0, 0)); 
