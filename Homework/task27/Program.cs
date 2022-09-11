// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:  ");
int N = Convert.ToInt32(Console.ReadLine());

int summa = 0;
int tempnumber = N;
while(tempnumber != 0)
{
    int digit = tempnumber % 10;
    summa = summa + digit;
    tempnumber= tempnumber / 10;
}
Console.Write($"Сумма всех цифр в заданном числе равно: {Math.Abs(summa)}");