Console.WriteLine("Введите первых два числа последовательности");
int a = int.Parse(Console.ReadLine() ?? "");
int b = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите количество чисел, которое нужно отобразить");
int numb = int.Parse(Console.ReadLine() ?? "");
int step = b - a;
int temp = 0;

string NumbersLength(int a, int numb)
{
    if (temp < numb)
    {
        temp++;
        return $"{a} " + NumbersLength(a + step, numb);
    }
    else
    {
        return String.Empty;
    }
}

Console.WriteLine(NumbersLength(a, numb));