// 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:  ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int digit1 = number / 10;
    int digit2 = digit1 % 10;
    Console.WriteLine(digit2);
}
else
{
    Console.WriteLine("Введено нетрехзначное число");
}