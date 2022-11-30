// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
/*
Console.Write("Enter count of row >>> ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter count of columns >>> ");
int columns = Convert.ToInt32(Console.ReadLine());


if (rows != columns)
{
    Console.WriteLine("");
    return;
}


int [,] GetArray(int r, int c, int min, int max)
{
    int [,] result = new int [r,c];
    for (int i = 0;  i < r; i++)
    {
        for (int j = 0;  j < c; j++)
        {
            result[i,j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}


void ChangeArray(int[,] array)
{
    int downRow = array.GetLength(1) - 1;
    for (int i = 0;  i < array.GetLength(0); i++)
    {
        int temp = array[0,i];
        array[0,i] = array[downRow, i];
        array[downRow, i] = temp;
    }

}


void PrintArray(int[,] inputArray)
{
    for (int i = 0;  i < inputArray.GetLength(0); i++)
    {
        for (int j = 0;  j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int [,] fixt = GetArray(rows, columns, 2, 9);
PrintArray(fixt);
ChangeArray(fixt);
 Console.WriteLine("—————————----------------------------------—");
PrintArray(fixt);

/*
Console.WriteLine("Введите число ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число ");
int columns = Convert.ToInt32(Console.ReadLine());

if (rows!=columns)
{
    Console.WriteLine("В данной матрице нельзя заменить");
    return;
}

int [,] GetArray(int m, int n, int min, int max)
{
    int [,] result = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(min,max+1);
          

        }
       
    }
    return result;

}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
           Console.Write(inputArray[i,j]);
          
        }
        Console.WriteLine();
       
    }
}

int [,] СhangArray(int[,] array)
{
    int[,] result = new int [array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           result[j,i] = array[i,j];
          
        }
       
       
    }
    return result;


}

int [,] array2 = GetArray(rows,columns,2,9);

PrintArray(array2);
Console.WriteLine("__________________");

PrintArray(СhangArray(array2));
*/


// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим

// Console.Write("Enter count of row >>> ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter count of columns >>> ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int minValue = int.MinValue;
// int minIndexRows = 0;
// int minIndexCols = 0;


// int [,] GetArray(int r, int c, int min, int max)
// {
//     int [,] result = new int [r,c];
//     for (int i = 0;  i < r; i++)
//     {
//         for (int j = 0;  j < c; j++)
//         {
//             result[i,j] = new Random().Next(min, max + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inputArray)
// {
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//         {
//            Console.Write(inputArray[i,j]);
//            if (minValue>inputArray[i,j])
//            {
//             minValue=inputArray[i,j];
//             minIndexRows= i;
//             minIndexCols =j;
            
//            }
          
//         }
//         Console.WriteLine();
       
//     }
// }


// int [,] СhangArray(int[,] array)
// {
//     int[,] result = new int [array.GetLength(0), array.GetLength(1)];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         if (i != minIndexRows)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (j != minIndexCols)
//                 {
//                     Console.Write(array[i,j]);
//                 }
//             }
//         }
//        Console.WriteLine();
//     }
//     return array;


// }


// int [,] array2 = GetArray(rows,columns,2,9);

// PrintArray(array2);
// Console.WriteLine("__________________");
// PrintArray(СhangArray(array2));


// double x = new Random().Next(-10, 10);
// Console.WriteLine(x);
// x += new Random().NextDouble();
// Console.WriteLine(x);
/*
int[] arr = new int[4]{1, 2, 3, 4};

for(int i = 0; i < arr.GetLength(0); i++)
{
    for(int j = 0; j < arr.GetLength(0) - i - 1; j++)
        if(arr[j] < arr[j + 1])
        {
            int temp = arr[j + 1];
            arr[j + 1] = arr[j];
            arr[j] = temp;
        } 
}

Console.WriteLine(string.Join(", ", arr));
*/