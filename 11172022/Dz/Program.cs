// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
Console.Write("Enter count of row >>> ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter count of columns >>> ");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double [row, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    { 
        double randomReal = (new Random().NextDouble() * 10) * (new Random().Next(-1, 2)); // Генерация случайного вещественного числа от -9.9 до 10
        matrix[i,j] = Math.Round(randomReal, 1);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}
*/


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
/*
Console.Write("Enter count of row >>> ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter count of columns >>> ");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double [row, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    { 
        matrix[i,j] = new Random().Next(1, 10);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}

Console.Write("Enter element position >>> ");
int position = Convert.ToInt32(Console.ReadLine());
int pos_x, pos_y;
pos_x = position / 10 - 1;  // 0 элемент массива
pos_y = position % 10 - 1;  // 6 элемент массива

if (pos_y > columns|| pos_x > row){    // Проверка нахождения числа в масиве
    Console.WriteLine("Sorry array does not have this element");
} else{
    Console.WriteLine($"{position} contains >>> {matrix[pos_x, pos_y]}");
}
*/


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
Console.Write("Enter count of row >>> ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter count of columns >>> ");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double [row, columns];
double [] arithmeticMean = new double [columns]; // Ср. арефм. столбцов

for (int i = 0; i < matrix.GetLength(0); i++)
{
    double sumOfColumnElements = 0; // Сумма элементов столбца
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(1, 10);
        Console.Write(matrix[i,j] + "\t");
        sumOfColumnElements += matrix[i,j];
    }
    Console.WriteLine();
    arithmeticMean[i] = sumOfColumnElements / columns;
}
Console.WriteLine("Averages in columns: " + string.Join(", ", arithmeticMean));
*/