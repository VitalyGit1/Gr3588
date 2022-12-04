//Вводим число, сразу парсим и проверяем на null
int number = int.Parse(Console.ReadLine() ?? "0");
//Условие: число должно быть трехзначным
if (number < 1000 && number > 99)
{
    //Выделяем вторую цифру из числа
    int Result = (number/10)%10;
    Console.Write("Вторая цифра - ");
    Console.WriteLine(Result);
}
//Если условие не выполняется, выводим надпись "Введите трехзначное число"
else
    Console.WriteLine("Введите трехзначное число");