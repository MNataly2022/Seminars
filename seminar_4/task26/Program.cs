// 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int ReadNumber(string massage)
// {
// Console.WriteLine(massage);                                        
// return Convert.ToInt32(Console.ReadLine()); 
// }

// int QuantityOfFigures(int n)
// {
//     int i = 0;
//     for (i = 1; n>0; i++)
//     {
//         n = n / 10;
//     }
//     return i;
// }

// int number = ReadNumber("Введите число");
// int figures = QuantityOfFigures(number);
// Console.WriteLine($"Количество цифр в числе = {figures}");



Console.Write("ВВедите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int x = 0;
if (number > 1)
{
    for (int i = 1; number > 0; i++)
    {
        number = number / 10;
        x++;
    }
    Console.Write($"Количество цифр в числе = {x}");
}
else
{
    Console.Write("Введите корректное число.");
}
