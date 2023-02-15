Console.WriteLine("Введите количество чисел которые нужно отобразить");
int a = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите значение числа, с которого начинать отсчет");
int numb = int.Parse(Console.ReadLine() ?? "");
int b = 0;

string NumbersLength(int a, int numb)
{
    if (b < a)
    {
        b++;
        return $"{numb} " + NumbersLength(a, numb+1);
    }
    else
    {
        return String.Empty;
    }
}

Console.WriteLine(NumbersLength(a,numb));
