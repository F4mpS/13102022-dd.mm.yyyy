/*
int[] inputArray = { 1, 2, 3, 4, 5 };

int lastIndex = inputArray. Length - 1; // 5 - 1 = 4

int[] resultArray = new int[inputArray.Length / 2 + inputArray.Length % 2];

for (int i = 0; i < resultArray.Length; i++)
{
    resultArray[i] = inputArray[i] * inputArray[lastIndex - i]; 
    if (i == lastIndex - i)
    {
        resultArray[i] = inputArray[i];
    }
}

Console.WriteLine($"Ответ: [{String.Join("; ",resultArray )}]");
*/


// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
/*
Console.WriteLine("Arrey size >>> ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Max element >>> ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Min element >>> ");
int min = Convert.ToInt32(Console.ReadLine());

int[] array = GetArray(size, max, min);
Console.WriteLine(String.Join(",", array));

ChangeArray(array);
Console.WriteLine(String.Join(",", array));

int[] GetArray(int size, int max, int min)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;

}

void ChangeArray(int[] array)
{
    for (int i = 0; i < (array.Length) / 2; i++)
    {
        int k = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = k;
    }
}
*/


// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
Console.Write("Enter a >>> ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b >>> ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter c >>> ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b) Console.WriteLine("IT EXISTS!!!");
*/


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
/*
Console.WriteLine("Enter dec num >>> ");
int a = Convert.ToInt32(Console.ReadLine());

string bin = "";

while (a > 0)
{
    bin = a % 2 + bin;
    a /= 2; 
}

Console.Write(bin);
*/


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 84


Console.Write("Enter N >>> ");
int n = Convert.ToInt32(Console.ReadLine());

int a = 0;
int b = 1;


for (int i = 0; i < n; i++)
{
    int next = a + b;
    Console.Write(a + " ");
    Console.Write(b + " ");
    a = next;
    b = b + next;
}



