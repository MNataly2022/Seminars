// 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++ )
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]:f2}  "); 
        }
        Console.WriteLine();
    }
}

double[,] GetMatrix(int rowsCount, int columnCount, double leftRange = -10.0, double rightRange = 10.0)
{
    double[,] matrix = new double[rowsCount, columnCount];

    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++ )
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.NextDouble() * (rightRange - leftRange) + leftRange;
        } 

    }
    return matrix;
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
double[,] matr = GetMatrix(m, n);
PrintMatrix(matr);