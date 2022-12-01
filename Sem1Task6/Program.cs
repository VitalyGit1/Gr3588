//Считываем данные с консоли
string? inputNum = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if (inputNum != null)
{
    //Парсим число
    int num = int.Parse(inputNum);

    //Условие: число делится на 2 без остатка
    if (num % 2 == 0)
    {
        //Выводим в консоль "Число является четным"
        Console.Write("Number is even");
    }
    else 
    {
        //Выводим в консоль "Число не является четным"
        Console.Write("Number is not even");
    }
}