// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int size = 4;
int counter = 0;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(99, 1000);
}

foreach(int i in array)
{
    if (i % 2 == 0) counter += 1;
}

Console.WriteLine("[" + string.Join(", ", array) + "]" + " >>> " + counter);
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int size = 6;
int sum = 0;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-100, 100);
}

for (int i = 0; i < size; i++)
{
    if (i % 2 != 0) sum += array[i];
}

Console.WriteLine("[" + string.Join(", ", array) + "] >>> " + sum);
*/


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
/*
const int size = 6;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0, 100);
}
int min = array[0], max = array[0], diff;

for (int i = 0; i < size; i++)
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}

diff = max - min;

Console.WriteLine("[" + string.Join(", ", array) + "] >>> " + diff + $" ({max} - {min})");
*/

