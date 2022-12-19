// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

int numbers = ReadData("Enter how many numbers you want to enter: ");
int result = CountPosNum(numbers);
PrintData("Numbers greater than zero: " + result);

int ReadData(string msg) // Read number from user
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res) // Print data to console
{
    Console.WriteLine(res);
}

int CountPosNum(int numbers) // Find numbers greater than 0
{
    int res = 0;
    while (numbers > 0)
    {
        if (ReadData("Enter number:  ") > 0) 
        res++;
        numbers = numbers - 1;
    }
    return res;
}