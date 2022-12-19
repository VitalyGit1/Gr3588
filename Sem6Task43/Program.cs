// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int k1 = ReadData("Введиче число к1: ");
int k2 = ReadData("Введиче число к2: ");
int b1 = ReadData("Введиче число b1: ");
int b2 = ReadData("Введиче число b2: ");

PrintData(FindPoint(k1, k2, b1, b2));

int ReadData(string msg) // Read number from user.
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res) // Print data to console.
{
    Console.WriteLine(res);
}

string FindPoint(int k1, int k2, int b1, int b2) // Method of finding unknowns.
{
    k1 = -k1;
    k2 = -k2;

    double d = (k2 * 1) - (k1 * 1);
    double dx = (b2 * 1) - (b1 * 1);
    double dy = (k2 * b1) - (k1 * b2); 

    double x = dx / d;
    double y = dy / d;

    string result = "(" + x + ", " + y + ")";

    return result;
}
