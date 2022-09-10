// 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int ReadNumber(string massage)
{
Console.WriteLine(massage);                                        
return Convert.ToInt32(Console.ReadLine()); 
}

int ProdNumberFrom1ToA(int N)
{
    if (N >= 1)
      {
         int sum = 1;
         for (int i = 2; i <= N; i++)
          {
            sum = sum * i; 
          }
         return sum; 
      }
    else
    {
      Console.WriteLine("A- должно быть не меньше 1!");
      return -1; 
    }   
}

int number = ReadNumber("Введите число");
int summa = ProdNumberFrom1ToA(number);
Console.WriteLine($"Произведение от 1 до А = {summa}");