// 18: Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
 int number = Convert.ToInt32(Console.ReadLine());

 if (number >= 1 && number <= 4)
 {
    if (number == 1)
    {
      Console.WriteLine("Диапазон координат: x>0, y>0"); 
    }
    if (number == 2)
    {
      Console.WriteLine("Диапазон координат: x<0, y>0"); 
    }
    if (number == 3)
    {
      Console.WriteLine("Диапазон координат: x<0, y<0"); 
    }
    if (number == 4)
    {
      Console.WriteLine("Диапазон координат: x>0, y<0"); 
    }
 }
else
        Console.WriteLine("Существует только 4 координатных четверти"); 