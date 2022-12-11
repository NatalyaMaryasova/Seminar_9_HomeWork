// Задайте значение N. Напишмите программу, которая выведет все натуральные числа 
// в промежутке от N до 1.

int n = ReadInt("Введите N: ");
Console.WriteLine(NaturalNumber(n));

int NaturalNumber(int n)
{
    if (n > 1)
    {
    Console.Write(n + ",");
    NaturalNumber(n-1);
    }
    return 1;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
