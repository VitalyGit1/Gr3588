// // Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int countRow = ReadData("Enter the number of lines: ");
int countColumn = ReadData("Enter the number of columns: ");
int[,] firstArray = Fill2DArray(countRow, countColumn, 10, 99);
PrintData("First array:");
Print2DArray(firstArray);
PrintData("Second array:");
int[,] secondArray = Fill2DArray(countRow, countColumn, 10, 99);
Print2DArray(secondArray);
int[,] resultMatrix = new int[countRow, countColumn];
MultiplyArray(firstArray, secondArray, resultMatrix);
PrintData("Multiplied matrix:");
Print2DArray(resultMatrix);

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

void MultiplyArray(int[,] firstArray, int[,] secondArray, int[,] resultMatrix) // Array multiplication.
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                sum += firstArray[i, k] * secondArray[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

void PrintData(string res) // Print data to console.
{
    Console.WriteLine(res);
}