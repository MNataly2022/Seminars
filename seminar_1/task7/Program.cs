// Напиши программу, которая принимает на входе число и на выходе показывакт последнюю цифру этого числа

Console.WriteLine("Введите трехзначное число:  ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    Double count = number % 10;
    Console.WriteLine(count);
}
else
{
    Console.WriteLine("Введено не трехзначное число");
}