//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if(inputLine!=null)
{
    //Парсим введенное число
    int inputNumber = int.Parse(inputLine);
    //Вводим дополнительную переменную
    int startNumber = 1;
    //Вводим переменную, в которой накапливаем результат
    string outLine = string.Empty;
    //Создаем цикл
    while(startNumber < inputNumber)
    {
        if (startNumber % 2 == 0)
        {
        Console.Write(startNumber);
        }
        //startNumber = startNumber+1;
        startNumber++;
    }
    //Добавляем начальное число
    outLine = outLine + inputNumber;
    //Условие: начальное число будет выводиться, только если оно четное 
    if (inputNumber % 2 == 0)
    {
        //Выводим данные в консоль
        Console.Write(inputNumber);
    }
}   