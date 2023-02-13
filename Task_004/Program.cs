Console.WriteLine("Введите начальное и конечное значения числового ряда");
int a = int.Parse(Console.ReadLine() ?? "");
int b = int.Parse(Console.ReadLine() ?? "");
int c = b - a + 1;
int[] numbers = new int[c];

void FillNumbers(int[] numbers)
{
    c = a;
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = c;
        c++;
        if (c > b)
        {
            break;
        }
    }
}

void PrintNumbers(int[] numbers)
{
    foreach (int i in numbers)
    {
        if (i == b)
        {
            Console.Write($"{i}.");
        }
        else
        {
            Console.Write($"{i}, ");
        }
    }
    Console.WriteLine();
}

void SumNumbers(int[] numbers)
{
    c = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        c = numbers[i] + c;
    }
}

FillNumbers(numbers);
PrintNumbers(numbers);
SumNumbers(numbers);
Console.WriteLine($"Сумма чисел от {a} до {b} равна {c}");