// // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = GenArray(15, 10, 99);
PrintArr(array);
double result = MinMax(array);
PrintData("Разница между максимальным и минимальным элементом массива: " + result);

double[] GenArray(int len, int minValue, int maxValue)
{
    double[] array = new double[len];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(minValue, maxValue) + rand.NextDouble();
    return array;
}

void PrintArr(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

double MinMax(double[] arr)
{
    double min = arr[0]; 
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = array[i];
        if (arr[i] < min)
            min = array[i];
    }

    double res = max - min;
    return res;
}

void PrintData(string res)
{
    Console.WriteLine(res);
}
