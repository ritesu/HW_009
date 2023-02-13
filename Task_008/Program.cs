Console.WriteLine("Введите количество чисел которые нужно отобразить");
int a = int.Parse(Console.ReadLine()??"");
Console.WriteLine("Введите значение числа, с которого начинать отсчет");
int numb = int.Parse(Console.ReadLine()??"");
int[] numbers = new int [a];
int end = numbers.Length-1;

void FillNumbers()
{
    numbers[0] = numb;
    numbers[1] = numb+1;
    int b = numb + 1;
    for(int i = 2; i < a; i++)
    {
        numbers[i] = numbers[i-2] + numbers[i-1];

    }
}

void PrintNumbers()
{
   for (int i = 0; i < numbers.Length; i++)
   {
    if (i == numbers.Length-1)
    {
        Console.Write($"{numbers[i]}.");
    }
    else
    {
        Console.Write($"{numbers[i]}, ");
    }
   }
}
FillNumbers();
PrintNumbers();