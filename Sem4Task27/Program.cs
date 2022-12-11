// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

int ReadData(string line)
{
    Console.WriteLine(line);
    int outNum = int.Parse(Console.ReadLine() ?? "0");
    return outNum;
}

int num = ReadData("Введите число:");

int result = SumDigit(num);

PrintData(result);

void PrintData(int res)
{
    Console.WriteLine(res);
}

int SumDigit(int num)
{
    int res = 0;
    while (num > 0) {
        res += num % 10;
        num = num / 10;
    }
    
    return res;
}

