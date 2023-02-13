Console.WriteLine("Введите с какого значения показать числовой ряд");
int a = int.Parse(Console.ReadLine() ?? "");
int[] numbers = Enumerable.Range(1, a).ToArray();
Array.Reverse(numbers);
void PrintNumbers(int[] numbers)
{
    foreach (int i in numbers)
    {
        if (i == 1)
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