// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*
int M, userInput, positivNumbers = 0;
Console.Write("Enter count of integers >>> ");
M = int.Parse(Console.ReadLine());

for (int i = 0; i < M; i++)
{
    userInput = int.Parse(Console.ReadLine());
    if (userInput > 0) positivNumbers++;
}
Console.Write($"User entered {positivNumbers} positive numbers");
*/


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
double b1, k1, b2, k2;

Console.Write("Enter b1 >>> ");
b1 = int.Parse(Console.ReadLine());
Console.Write("Enter k1 >>> ");
k1 = int.Parse(Console.ReadLine());
Console.Write("Enter b2 >>> ");
b2 = int.Parse(Console.ReadLine());
Console.Write("Enter k1 >>> ");
k2 = int.Parse(Console.ReadLine());

if (k1 == k2)
{
     Console.WriteLine("Lines are parallel");
}
else 
{
    double x = (b2 - b1) / (k1 - k2); 
    double y = k1 * x + b1;
    Console.WriteLine($"Lines are crossing in ({x}, {y})");
}
*/