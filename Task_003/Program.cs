Console.WriteLine("Введите начальное и конечное значения числового ряда");
int a = int.Parse(Console.ReadLine() ?? "");
int b = int.Parse(Console.ReadLine() ?? "");

string NumbersLength(int a, int b)
{
    if (a <= b)
    {
        return $"{a} " + NumbersLength(a+1, b);
    }
    else
    {
        return String.Empty;
    }
}

Console.WriteLine(NumbersLength(a, b));