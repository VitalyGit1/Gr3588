//Считываем данные с консоли
string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();
string? inputNum3 = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if (inputNum1 != null && inputNum2 != null && inputNum3 != null) {
    //Парсим наши числа
    int num1 = int.Parse(inputNum1);
    int num2 = int.Parse(inputNum2);
    int num3 = int.Parse(inputNum3);

    // Условие: является ли первое число максимальным
    if (num1 > num2 && num1 > num3) {
        Console.Write("max = "); 
        Console.WriteLine(num1);
    }

    // Условие: является ли второе число максимальным
    else if (num2 > num1 && num2 > num3) {
        Console.Write("max = "); 
        Console.WriteLine(num2);
    }

    // Условие: является ли третье число максимальным
    else if (num3 > num1 && num3 > num2) {
        Console.Write("max = "); 
        Console.WriteLine(num3);
    }

    // Проверяем, являеются ли некоторые числа одинаковыми
    else {
        Console.Write("Some of the number is equal");
    }

}
