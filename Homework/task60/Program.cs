// 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента. Массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] arr = new int[2,2,2];
Random rand = new Random();

int[]array = new int[8];
for(int i = 0; i <  array.Length; i++)
{
    int number = rand.Next(10,100);      // формируется случайное число в диапазоне
    if (array.Contains(number)) i--;    // Проверка, содержится ли число в массиве. Если "Да",
                                       // то возврат назад (в пред.строку кода) и заново формируем число
    else array[i] = number;           // Иначе: в массив записываем число
}

int count = 0;                     // счетчик для прохода по одномерному массиву

for(int i = 0; i < arr.GetLength(0); i++)
{
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        for(int k = 0; k < arr.GetLength(2); k++)
        {     
               // arr[i,j,k] = rand.Next(10.99); Заполнение случайными двузначными числами

               arr[i, j, k] = array[count];  
               count ++; 
               Console.Write($"{arr[i, j, k]} ({i}, {j}, {k})");               
        }
        Console.WriteLine();
    }
}
