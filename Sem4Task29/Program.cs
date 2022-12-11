// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res, int[] arr)
{
    Console.WriteLine(res);
    PrintArr(arr);
}

int[] GenArr(int num, int bot, int top)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(bot, top);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int arrLen = ReadData("Введите длину массива:");
int bot = ReadData("Введите нижнюю границу массива:");
int top = ReadData("Введите верхнюю границу массива:");

int[] arr = GenArr(arrLen, bot, top);

PrintData("Сгененрированный массив:", arr);

