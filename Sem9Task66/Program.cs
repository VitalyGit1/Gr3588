// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int M = ReadData("Enter number M: ");
int N = ReadData("Enter number N: ");
int sum = SumMNRec(M, N);
PrintData("The sum of natural elements between M and N: " + sum);

int ReadData(string line) // Read data from user.
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintData(string res) // Print data to console.
{
    Console.WriteLine(res);
}

int SumMNRec(int M, int N) // Find the sum of natural elements from M to N using recursion.
{
    if (M >= N) return N;
    return M + SumMNRec(M + 1, N);
}
