Console.WriteLine("Введите первых два числа последовательности");
int a = int.Parse(Console.ReadLine() ?? "");
int b = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите количество чисел, которое нужно отобразить");
int numb = int.Parse(Console.ReadLine() ?? "");
int[] numbers = new int[numb];
void MathNumbers()
{
    numbers[0] = a;
    numbers[1] = b;
    int temp = b - a;
    for (int i = 2; i < numbers.Length; i++)
    {
        numbers[i] = numbers[i - 1] + temp;
    }
}

void PrintResult()
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i == numbers.Length - 1)
        {
            Console.Write($"{numbers[i]}.");
        }
        else
        {
            Console.Write($"{numbers[i]}, ");
        }
    }
}

MathNumbers();
PrintResult();

