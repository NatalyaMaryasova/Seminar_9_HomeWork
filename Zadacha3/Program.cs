// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m = ReadInt("Введите первое неотрицательное число m: ");
int n = ReadInt("Введите второе неотрицательное число n: ");

int akkermanFunction = Akkerman(m, n);
Console.Write($"m = {m}, n = {n} -> A(m, n) = {akkermanFunction}");

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return(n + 1);
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman (m-1, 1);
    }
    else
    {
        return Akkerman(m-1, Akkerman(m, n-1));
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
