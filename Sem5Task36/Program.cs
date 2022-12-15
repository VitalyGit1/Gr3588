// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = GenArray(15, 10, 99);
PrintArr(array);
int result = SumOdd(array);
PrintData("Сумма нечётных чисел: " + result);

int[] GenArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

int SumOdd(int[] arr)
{
    int res = 0;
    int i = 1;
    while (i < arr.Length)
    {
        res += arr[i];
        i = i + 2;
    }
    return res;
}


