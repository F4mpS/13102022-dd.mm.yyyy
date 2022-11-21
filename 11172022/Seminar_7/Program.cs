// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
/*
Console.Write("Enter count of row >>> ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter count of columns >>> ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [row, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(11);

        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}
*/

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

/*
Console.Write("Enter count of row >>> ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter count of columns >>> ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [row, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = i + j;

        Console.Write(matrix[i,j] + "\t");
    }
    for(int k = 0; k < 2; k++){
        Console.WriteLine("\n");
    }
}
*/


// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
Console.Write("Enter count of row >>> ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter count of columns >>> ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [row, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(5,7);

        if (i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i,j]; 
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}
*/


// **Задача 51:** Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Write("Enter count of row >>> ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter count of columns >>> ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [row, columns];
int sum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(11);

        if (i == j) sum += matrix[i,j]; 
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\t >>> " + sum);




