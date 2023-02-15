Console.WriteLine("Введите число");
int numb = int.Parse(Console.ReadLine() ?? "");
int SumNumbers(int numb)
{
    if (numb == 0)
    {
        return 0;
    }
    else
    {
        return numb % 10 + SumNumbers(numb / 10);
    }
}
Console.WriteLine(SumNumbers(numb));