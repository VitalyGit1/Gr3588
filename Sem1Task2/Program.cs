//Считываем данные с консоли
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();
//Проверяем, чтобы данные не были пустыми
if (num1Line!=null && num2Line!=null)
{
    //Парсим первое число
    int num1 = int.Parse(num1Line);
    //Парсим второе число
    int num2 = int.Parse(num2Line);
    //Даем условие
    if (num1 < num2)
    {
        //Выводим данные в консоль
        Console.Write("max = "); 
        Console.WriteLine(num2Line);
    }
    else
    {
        //Выводим данные в консоль
        Console.Write("max = "); 
        Console.WriteLine(num1Line);
    }
}