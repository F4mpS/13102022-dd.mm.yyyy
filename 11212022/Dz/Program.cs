// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
/*
void FillMatrix(matrix1i void FillMatrix(matri21i;nt[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
           Console.Write(inputMatrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
}

void SortArray(int[,] matrix)    // Bubble sort
{

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(1) - j - 1; k++)
                {
                    if(matrix[i,k] < matrix[i,k + 1])
                    {
                        int temp = matrix[i,k + 1];
                        matrix[i,k + 1] = matrix[i,k];
                        matrix[i,k] = temp;
                    }
                } 
        }
    }
}



int row = 4;
int columns = 4;
int[,] matrix = new int[row,columns];

FillMatrix(matrix1m 
FillMatrix(matri21m;atrix);
PrintArray(matrix);
SortArray(matrix);
PrintArray(matrix);
*/


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int MinValueString(int[,] matrix)
{
    int sum = 0, minSumRow = 1, temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        if (temp > sum)
        {
            minSumRow = i + 1;  
            temp = sum;
        }
        if (i == 0) temp = sum;     // Присвоение стартого значения для хранилища
    }
    return minSumRow;
}

int row = 4;
int columns = 2;
int[,] matrix = new int[row,columns];

FillMatrix(matrix1m 
FillMatrix(matri21m;atrix);
PrintArray(matrix);
Console.WriteLine("The row with minimal elements sum >>> " + MinValueString(matrix));
*/


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18    
/*
int[,] MultiplyMatrix(int[,] matrixA, int[,]matrixB)
{

    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            matrixC[i,j] = 0;

            for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
        }   
    }
    return matrixC;
}

int row = 2;
int columns = 2;
int[,] matrix1 = new int[row, columns];
int[,] matrix2 = new int[row, columns];

FillMatrix(matrix1);
FillMatrix(matrix2);
PrintMatrix(matrix1);
PrintMatrix(matrix2);

PrintMatrix(MultiplyMatrix(matrix1, matrix2));
*/
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
/*
int[,,] MakeArray3D(int a, int b, int c)
{
    int[,,] array = new int[a,b,c];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                {
                    int temp = new Random().Next(2,10);
                    if (ConformityCheck(array, temp))
                    {
                        k--;
                    }
                    else
                    {
                        array[i,j,k] = temp;
                    }
                }
        }
    }
    return array;
}

void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
                }
            Console.WriteLine();
        }   
    }
}

bool ConformityCheck(int[,,] array, int x)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i,j,k] == x) return true;
            }
        }   
    }
    return false;
}

const int a = 2;
const int b = 2;
const int c = 2;
var array3D = MakeArray3D(a, b, c);
PrintArray3D(array3D);
*/
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillMatrix(int[,] matrix)
{
    int temp = 0;
    int start = 0;
    int end = 0;
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);


    for (int i = 0; i < rows; i++, temp++)
    {
        matrix[0,i] = temp + 1;
    }
    PrintMatrix(matrix);


    for (int i = 1; i < rows; i++, temp++)
    {
        matrix[i,rows - 1] = temp + 1;
    }
    PrintMatrix(matrix);


    for (int i = rows - 1; i > 0; i--, temp++)
    {
        matrix[columns - 1,i - 1] = temp + 1;
    }
    PrintMatrix(matrix);


    for (int i = rows - 2; i > 1; i--, temp++)
    {
        matrix[i,0] = temp + 1;
    }
    PrintMatrix(matrix);


    for (int i = 1; i < columns - 1; i++, temp++)
    {
        matrix[1,i] = temp + 1;
    }
    PrintMatrix(matrix);


    for (int i = 2; i < rows - 1; i++, temp++)
    {
        matrix[2,i] = temp + 1;
    }
    PrintMatrix(matrix);


    for (int i = 1; i > 0; i--, temp++)
    {
        matrix[2,i] = temp + 1;
    }
    PrintMatrix(matrix);
}

int[,] matrix = new int[4,4];
FillMatrix(matrix);
PrintMatrix(matrix);







































/*
void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
        }
    }
}
*/
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
           Console.Write(inputMatrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
}
