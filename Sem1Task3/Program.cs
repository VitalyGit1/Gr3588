// Считываем данные с консоли
string? inputLine = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми
if(inputLine!=null)
{
    //Создаем массив с днями недели
    string[] dayOfWeek = new string[7];
    dayOfWeek[0] = "Monday";
    dayOfWeek[1] = "Tuesday";
    dayOfWeek[2] = "Wednesday";
    dayOfWeek[3] = "Thursday";
    dayOfWeek[4] = "Friday";
    dayOfWeek[5] = "Saturday";
    dayOfWeek[6] = "Sunday";
    //Парсим введенное число
    int inputNumber = int.Parse(inputLine);
    //Находим название дня недели по введенному номеру
    string outDayOfWeek = dayOfWeek[inputNumber-1];
    //Выводим данные в консоль
    Console.WriteLine(outDayOfWeek);
}
