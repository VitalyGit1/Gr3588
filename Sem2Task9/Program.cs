// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

System.Random numberSintezator = new System.Random();

int number = numberSintezator.Next(10,100);

Console.WriteLine(number);

int firstNumber = number/10;
int secondNumber = number%10;

if (firstNumber>secondNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(secondNumber);
}

//Вариант 2
char[] digits = numberSintezator.Next(10,100).ToString().ToCharArray();

firstNumber = ((int)digits[0])-48;
secondNumber = ((int)digits[1])-48;

int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;

Console.WriteLine(resultNumber);