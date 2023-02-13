Console.WriteLine("Введите число");
int numb = int.Parse(Console.ReadLine() ?? "");
int[] numbers = new int[0];

void CorrectNumbers()
{
    int count = 0;
    for (int a = numb; a > 0;)
    {
        a = a / 10;
        count++;
    }
    numbers = new int[count];
}

void FillNumbers()
{
    int a = numb;
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = a % 10;
        a = a / 10;
    }
}

int sum = 0;
void SumNumbers()
{
    for (int i = 0; i < numbers.Length; i++)
    {
        sum = numbers[i] + sum;
    }
}

CorrectNumbers();
FillNumbers();
SumNumbers();
Console.WriteLine($"Сумма цифр числа {numb} равна {sum}");