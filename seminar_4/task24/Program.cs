// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int ReadNumber(string massage)
{
Console.WriteLine(massage);                                        
return Convert.ToInt32(Console.ReadLine()); 
}

int SumNumberFrom1ToA(int a)
{
    if (a >=1)
    {
    int sum = 0;
    for (int i = 1; i<= a; i++)
    {
        sum = sum + i; // sum += i;- альтернативный вариант записи накопления суммы
    }
    return sum;  //вернем накопившуюся сумму
    }
    else
    {
    Console.WriteLine("A- должно быть не меньше 1!");
    return -1; // маяк- неправильная сумма(сообщение об ошибке)
    }   
}

int number = ReadNumber("Введите число");
int summa = SumNumberFrom1ToA(number);
Console.WriteLine($"Сумма элементов от 1 до А = {summa}");
