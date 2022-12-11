// Задайте значения M и N. Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N.

int m = ReadInt("Введите M: ");
int n = ReadInt("Введите N: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}
Console.Write($"M = {m}, N = {n} -> Сумма = ");
PrintSum(m, n, temp = 0);

void PrintSum(int m, int n, int sum)
{
    sum = sum + n;
    if(n <= m)
    {
        Console.Write($"{sum}");
        return;
    }
    PrintSum(m, n-1, sum);
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
