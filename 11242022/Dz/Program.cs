﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
string foo(int N)
{
    if (N == 1) return N.ToString();
    return (N + " " + foo(N - 1));
}
int  n;
Console.Write("Enter N >>> "); n = Convert.ToInt16(Console.ReadLine()); Console.WriteLine(foo(n));
*/
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int foo(int start, int end)
{
    if (start == end) return end;
    return (start + foo(start + 1, end)); 
}
int n, m;
Console.Write("Enter N >>> ");
n = Convert.ToInt16(Console.ReadLine());
Console.Write("Enter M >>> ");
m = Convert.ToInt16(Console.ReadLine());

Console.WriteLine(foo(n, m));
*/
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
/*
int foo(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return foo(m - 1, 1);
    return (foo(m - 1, foo(m, n - 1)));
}
int n, m;
Console.Write("Enter M >>> ");
m = Convert.ToInt16(Console.ReadLine());
Console.Write("Enter N >>> ");
n = Convert.ToInt16(Console.ReadLine());

Console.WriteLine(foo(m, n));
*/