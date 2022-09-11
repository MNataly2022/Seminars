// 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А :  ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число B :  ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 > 0)
{
int res = 1;
for(int i=1; i <= number2; i++)
{
    res = res * number1;
}
Console.WriteLine($"Число {number1} в степени {number2} = {res}");
}
else
{
    Console.WriteLine("Число B должно быть натуральным");
}