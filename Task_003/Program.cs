Console.WriteLine("Введите начальное и конечное значения числового ряда");
int a = int.Parse(Console.ReadLine() ?? "");
int b = int.Parse(Console.ReadLine() ?? "");
int c = b - a + 1;
int[] numbers = new int[c];

void FillNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = a;
        a++;
        if (a > b)
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

FillNumbers(numbers);
PrintNumbers(numbers);