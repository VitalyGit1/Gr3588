// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

int ReadData(string line)
{
    Console.WriteLine(line);
    int outNum = int.Parse(Console.ReadLine() ?? "0");
    return outNum;
}

int numberA = ReadData("Введите число:");
int numberB = ReadData("Введите степень:");

int result = Pow(numberA, numberB);

PrintData(result);

int Pow(int numA, int numB)
{
    int res = 1;
    for (int i = 1; i <= numB; i++)
    {
        res = res * numA;
    }
    return res;
}

void PrintData(int res)
{
    Console.WriteLine("Ответ равен:");
    Console.WriteLine(res);
}
