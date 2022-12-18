// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// int num1 = ReadData("Введите длину a: ");
// int num2 = ReadData("Введите длину b: ");
// int num3 = ReadData("Введите длину c: ");
// TriangleTest(num1, num2, num3);

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// void TriangleTest(int a, int b, int c)
// {
//     int num1 = a;
//     int num2 = b;
//     int num3 = c;
//     if ((a + b > c) && (a + c > b) && (b + c > a))
//         Console.WriteLine("Треугольник со сторонами такой длины существовать может");
//     else
//         Console.WriteLine("Треугольник со сторонами такой длины существовать не может");
// }

int a = ReadData("Введите первое число: ");
int b = ReadData("Введите второе число: ");
int c = ReadData("Введите третье число: ");

if (TriangleTest(a, b, c)) PrintData("Может существовать треугольник сo сторонами такой длины");
else PrintData("Треугольник сo сторонами такой длины не существует");
//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

bool TriangleTest(int a, int b, int c)
{
    return ((a + b > c) && (a + c > b) && (b + c > a));
}



// int A = ReadData("Enter first number: ");
// int B = ReadData("Enter second number: ");
// int C = ReadData("Enter third number: ");
// TriangleTest(A,B,C);
// PrintData ("Result: "  + TriangleTest(A,B,C));


// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }


// void PrintData(string res)
// {
//     Console.WriteLine(res);
// }

// bool TriangleTest (int a, int b, int c)
// {
//     return ((a+b>c) && (a+c>b) && (b+c>a));
// }
