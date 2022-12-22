// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int countRow = ReadData("Enter the number of lines: ");
int countColumn = ReadData("Enter the number of columns: ");
int [,] arr2D = Fill2DArray(countRow, countColumn, 10, 99);
Print2DArray(arr2D);
double [] res = Average(arr2D, countRow, countColumn);
PrintData("Average: ");
PrintArray(res);

int ReadData(string line) // Read data from user.
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder) // Create a two-dimensional array of integers.
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

void Print2DArray(int[,] matrix) // Print a two-dimensional array.
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

void PrintArray(double[] arr) // Print a one-dimensional array of averages.
{
    Console.Write("[");
    for (int j = 0; j < arr.Length - 1; j++)
    {
        Console.Write(arr[j] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

double[] Average(int[,] arr, int i, int j) // Find the average value of the numbers of columns. 
{
    double[] avg = new double[arr.GetLength(1)];
    for (j = 0; j < arr.GetLength(1); j++)
    {
        for (i = 0; i < arr.GetLength(0); i++)
            avg[j] += arr[i, j];
            avg[j] = avg[j] / arr.GetLength(0);
    }
    return avg;
}

void PrintData(string res) // Print data to console.
{
    Console.Write(res);
}
