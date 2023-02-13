Console.WriteLine("Укажите последнее значение числового ряда");
int a = int.Parse(Console.ReadLine() ?? "");
int[] numbers = Enumerable.Range(1, a).ToArray();
void PrintNumbers(int[] numbers)
{
    foreach (int i in numbers)
    {
        if (i == a)
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

PrintNumbers(numbers);