// Console.Write("Enter number >>> ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(SumNum(num));

// int SumNum(int number) 
// {
//     int sum = 0;
//     int count = 0;

//     while (number > count)
//     {
//         count++;
//         sum += count;
//     }

//     return sum;
// }


/*
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

// Console.Write("Enter your number >>> ");
// string num = Console.ReadLine();

// char[] NumSymbols = num.ToCharArray(); 

// Console.WriteLine(NumSymbols.Length);


/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

// int size = 8;
// int[] array = GetArray(size);

// int[] GetArray(int size)
// {
//     int[] array = new int [size];

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//     }

//     return array;
// }

// Console.WriteLine(String.Join(",", array));


/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

Console.Write("Enter your number >>> ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Factorial(num));

int Factorial(int num)
{
    int result = 1;
    for (int i = 2; i < num + 1; i++)
    {
        result *= i;
    }
    return result;
}
