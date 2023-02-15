Console.WriteLine("Введите число, которе нужно возвести в степень");
int a = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите степень");
int b = int.Parse(Console.ReadLine() ?? "");

int Result(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    else
    {
        return Result(a, b - 1) * a;
    }
}
Console.WriteLine($"Число {a} возведенное в степень {b} равна {Result(a, b)}");