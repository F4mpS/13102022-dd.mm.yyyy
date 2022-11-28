// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
/*
Console.Write("Enter number >>> ");
int n = Convert.ToInt32(Console.ReadLine());

string PrintNumber(int start, int end)
{
    if(end == start) 
    {
        return end.ToString();
    }
    return (start + " " + PrintNumber(start + 1, end));
}

Console.WriteLine(PrintNumber(1, n));
*/

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
/*
Console.Write("Enter number >>> ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number >>> ");
int n = Convert.ToInt32(Console.ReadLine());

string PrintNumber(int start, int end)
{
    if (start > end) 
    {
        return "Gandon";
    }
    if (start == end)
    {
        return end.ToString();
    }
    return (start + ", " + PrintNumber(start + 1, end));
}

Console.WriteLine(PrintNumber(m, n));
*/


// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Enter your number >>> ");
string str = Console.ReadLine();
int count;

int DigitsSum(string s)
{
    if (s.Length == 0) return 0;
    count = Convert.ToInt32(s[0] - '0') + DigitsSum(s.Substring(1));
    return count;
}
Console.WriteLine(DigitsSum(str));

