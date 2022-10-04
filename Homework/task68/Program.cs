﻿//Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9  m = 3, n = 2 -> A(m,n) = 29

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int AkkermanFun(int num1, int num2)
{
    if (num1 == 0)
    {
        return num2 + 1;
    }
    else
    {
        if ((num1 != 0) && (num2 == 0))
            return AkkermanFun(num1 - 1, 1);
        else
            return AkkermanFun(num1 - 1, AkkermanFun(num1, num2 - 1));
    }
}

int m = ReadNumber("Введите M");
int n = ReadNumber("Введите N");
Console.Write(AkkermanFun(m, n));
