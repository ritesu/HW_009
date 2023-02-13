Console.WriteLine("Введите число, которе нужно возвести в степень");
int a = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите степень");
int b = int.Parse(Console.ReadLine() ?? "");
int result = a;

void Result()
{
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
}
Result();
Console.WriteLine($"Число {a} возведенное в степень {b} равно {result}");