// Написать программу, которая на вход принимает одно число N 
// А на выходе показывает все целые числа в промежутке от -N до N
// 4-> -4 -3 -2 -1 0 1 2 3 4 

Console.WriteLine("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());

int count = - number;
while(count <= number)
{
  Console.Write(count + " ");
  count = count + 1;   
}