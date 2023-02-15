Console.WriteLine("Введите начальное и конечное значения числового ряда");
int a = int.Parse(Console.ReadLine() ?? "");
int b = int.Parse(Console.ReadLine() ?? "");

int SumNumbers(int a, int b)
{
    if (a > b)
    {
        return 0;
    }
    else
    {
        return a + SumNumbers(a + 1, b);
    }
}
Console.WriteLine($"Сумма чисел от {a} до {b} равна {SumNumbers(a, b)}");