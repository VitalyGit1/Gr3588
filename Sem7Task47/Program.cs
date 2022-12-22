// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
double[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArray(arr2D);

int ReadData(string line) // Read data from user.
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void Print2DArray(double[,] matrix) // Print a two-dimensional array.
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

double[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder) // Create a two-dimensional array of numbers with a comma.
{
    System.Random rand = new System.Random();
    double[,] array2D = new double[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1)+ rand.NextDouble();
        }
    }
    return array2D;
}

