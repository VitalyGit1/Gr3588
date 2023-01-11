// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int countRow = ReadData("Enter the number of lines: ");
int countColumn = ReadData("Enter the number of columns: ");
int[,] array = Fill2DArray(countRow, countColumn, 10, 99);
Print2DArray(array);
int minSumLine = 0;
int sumLine = SumLineElements(array, 0);

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

for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

PrintData($"\n{minSumLine+1} - The line with the smallest sum ({sumLine}) elements ");

int SumLineElements(int[,] array, int i) // Finding the row with the smallest sum.
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

void PrintData(string res) // Print data to console.
{
    Console.WriteLine(res);
}
