// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// создаем экземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();   

// получаем случайное число
int num = numberSintezator.Next(100,1000);             
Console.WriteLine (num);                         

int result = (num/100)*10 + num%10;
Console.WriteLine (result);
