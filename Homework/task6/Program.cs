// 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Введите число, отличное от нуля");
int number = Convert.ToInt32(Console.ReadLine());
if(number >0 || number < 0 )
{
if (number % 2 == 0)
{
    Console.Write("Число четное");
}
else
    Console.Write("Число нечетное");
}
else
{ 
    Console.WriteLine("Введите число, отличное от нуля");
}