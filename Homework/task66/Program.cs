// 66: Задайте значения M и N. Напишите программу, которая  
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120  M = 4; N = 8. -> 30

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigits(int num1, int num2)
{
    if (num1 > num2) return 0;
    else
    {
        return num1 + SumDigits(num1 + 1, num2);
    }
}

int m = ReadNumber("Введите M");
int n = ReadNumber("Введите N");
if (n < m)
{
    Console.Write(SumDigits(n, m));
}
else if (n > m)
{
    Console.Write(SumDigits(m, n));
}
else if (n == m)
Console.Write(0);
