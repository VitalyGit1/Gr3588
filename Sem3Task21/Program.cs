//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int x1 = ReadData("Введите x1: ");
int x2 = ReadData("Введите x2: ");
int y1 = ReadData("Введите y1: ");
int y2 = ReadData("Введите y2: ");
int z1 = ReadData("Введите z1: ");
int z2 = ReadData("Введите z2: ");

double CalculateLength(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double res = 0;
    res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
    return res;
}


void PrintData(string msg, double result)
{
    Console.WriteLine(msg + result);
}

PrintData("Расстояние между точками ", CalculateLength(x1, x2, y1, y2, z1, z2));

