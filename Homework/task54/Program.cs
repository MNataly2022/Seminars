// 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по возрастанию элементы каждой строки двумерного массива.

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 9)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            int minPosition = j;
            for (int k = j+1; k < matrix.GetLength(1); k++ )
            {
                if (matrix[i, k] < matrix[i, minPosition])
                {
                    minPosition = k;
                }
            }
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, minPosition];
            matrix[i, minPosition] = temp;
        }
    }
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
Console.WriteLine("\n");
ChangeMatrix(matr);
PrintMatrix(matr);

