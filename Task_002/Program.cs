Console.WriteLine("Введите с какого значения показать числовой ряд");
int a = 1;
int b = int.Parse(Console.ReadLine() ?? "");

string NumbersLength(int b, int a)
{
    if (b >= a)
    {
        return $"{b} " + NumbersLength(b-1, a);
    }
    else
    {
        return String.Empty;
    }
}

Console.WriteLine(NumbersLength(b, a));