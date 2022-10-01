// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] GetResultMatrix(int[,] FirstMatrix, int[,] SecondMatrix)
{
    int[,] resultMatrix = new int[FirstMatrix.GetLength(0), FirstMatrix.GetLength(1)];
    for (int i = 0; i < FirstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < FirstMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = FirstMatrix[i, j] * SecondMatrix[i, j];
        }
    }
    return resultMatrix;
}

int m = ReadNumber("Введите количество строк в обеих матрицах");
int n = ReadNumber("Введите количество столбцов в обеих матрицах");

int[,] matr1 = GetMatrix(m, n);
PrintMatrix(matr1);
Console.WriteLine("\n");

int[,] matr2 = GetMatrix(m, n);
PrintMatrix(matr2);
Console.WriteLine("\n");

int[,] matr3 = GetResultMatrix(matr1, matr2);
PrintMatrix(matr3);
