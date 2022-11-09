// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
Console.Write("Enter ur number >>> ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter ur number >>> ");
int b = Convert.ToInt32(Console.ReadLine());

int start = a;

for (int i = 1; i < b; i++)
{
    a = start * a;
}

Console.WriteLine(a);
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
Console.Write("Enter ur number >>> ");
string num = Console.ReadLine();
char[] symb_arr = num.ToCharArray();
int sum = 0;

foreach (char i in symb_arr)
{
    sum += i - '0';     // ascii творит чудеса
}
Console.WriteLine(sum);
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*
int[] arr = new int[8];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100);
}

foreach(int i in arr)
{
    Console.WriteLine(i);
}
*/



