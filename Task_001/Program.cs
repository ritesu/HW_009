Console.WriteLine("Укажите последнее значение числового ряда");
int a = 1;
int b = int.Parse(Console.ReadLine() ?? "");

string NumbersLength(int a, int b)
{
    if (a < b)
    {
        return $"{a} " + NumbersLength(a+1, b);
    }
    else
    {
        return String.Empty;
    }
}
Console.WriteLine(NumbersLength(a, b));