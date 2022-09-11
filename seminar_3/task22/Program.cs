﻿// 22: Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число:  ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 0)
{
    for (int i = 1; i<= N; i++)
    {
       Console.Write(i * i +" ");
    }
}
else
{
    Console.WriteLine("N должно быть больше 0");
}

// ВТОРОЙ СПОСОБ:
// int i = 1;
// if (N > 0)
// {
//    while(i <= N)
//    {
//     Console.Write(i * i +" ");
//     i++;
//    }
// } 
// else
//  {
//     Console.WriteLine("N должно быть больше 0");
//  }  