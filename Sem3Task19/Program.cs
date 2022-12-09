// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int num = readData("Введите пятизначный палиндром:");

if (num == 0)
{
    return;
}

bool result = palinTest(num);

printData(result);

int readData(string msg)
{
    Console.WriteLine(msg);

    string? inputNumber = Console.ReadLine();

    if (inputNumber.Length != 5)
    {
        Console.WriteLine("Число не является пятизначным!");
        return 0;
    }
    return int.Parse(inputNumber ?? "0");
}

bool palinTest(int num)
{
    bool result = false;
    result = (num / 10000 == num % 10) && (num / 1000) % 10 == (num / 10) % 10;
    return result;
}

void printData(bool result)
{
    if (result == true)
    {
        Console.WriteLine("Введенное число - палиндром!");
    }
    else
    {
        Console.WriteLine("Введенное число - не палиндром!");
    }
}