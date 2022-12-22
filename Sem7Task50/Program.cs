// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int row = ReadData("Enter the number of lines: ");
int column = ReadData("Enter the number of columns: ");
int x = ReadData("Enter the x position of the element: ");
int y = ReadData("Enter the y position of the element: ");
int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArray(arr2D);
int elem = SearchElem(arr2D, x, y);
PrintData("Element value: " + elem);

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

int SearchElem(int[,] arr, int x, int y) // Find the value of the requested element.
{
    int elem = -1;
    if (x < arr.GetLength(0))
    {
        if (y < arr.GetLength(1))
        {
            elem = arr[x, y];
        }
    }
    else Console.WriteLine("No such element!");
    return elem;
}

void PrintData(string res) // Print data to console.
{
    Console.WriteLine(res);
}