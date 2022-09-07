// 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    while(number > 999)
    {
        number = number / 10;
    }
    int digit = number % 10;
    Console.WriteLine(digit);
}
else
{
    Console.WriteLine("третьей цифры нет");
}