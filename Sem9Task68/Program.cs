// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int M = ReadData("Enter number M: ");
int N = ReadData("Enter number N: ");
int elem = AkkermanFunc(M, N);
PrintData("Calculations: " + elem);
PrintData("Calculations: " + AkkermanFunc(3,2));

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

int AkkermanFunc(int m, int n) // Ackerman function calculation program using recursion.
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AkkermanFunc(m - 1, 1);
    }
    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}



