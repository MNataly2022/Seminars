//19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число:  ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 9999 && n < 100000)
{
    if (n / 10000 == n % 10 && (n % 10000 / 1000 == (n % 100) / 10))
    {    
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }

}
else
{
    Console.WriteLine("Введено непятизначное число");
}