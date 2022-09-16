// 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, кот. покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1); 
    }
    return arr;
}

int Amount(int[] arr)
{
    int num = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0) 
        {
            num = num + 1; 
        }
    }
    return num;
}

int[] array = GetArray(12, 100, 999);
Console.WriteLine(string.Join(", ", array));
int number = Amount(array);
Console.WriteLine($"Число четных чисел в массиве= {number}");