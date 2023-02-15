Console.WriteLine("Введите два значения для вычисления");
int n = int.Parse(Console.ReadLine() ?? "");
int m = int.Parse(Console.ReadLine() ?? "");
int A(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    if (n > 0 && m == 0)
    {
        return A(n - 1, 1);
    }
    if (n > 0 && m > 0)
    {
        return A(n - 1, A(n, m - 1));
    }
    return A(n, m);
}
Console.WriteLine($"Значение функции Аккермана равна {A(n, m)}");