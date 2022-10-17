// 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
    Console.Write("Введите число >>> ");
    int num1 = Convert.ToInt16(Console.ReadLine());

    Console.Write("Введите число >>> ");
    int num2 = Convert.ToInt16(Console.ReadLine());

    if (num1 > num2) { 
        Console.WriteLine(num1 + " >>> большее");
        Console.Write(num2 + " >>> меньшее");

    } else {
        Console.WriteLine(num2 + " >>> большее");
        Console.Write(num1 + " >>> меньшее");
    }
*/

// 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
    Console.Write("Введите число >>> ");
    int num1 = Convert.ToInt16(Console.ReadLine());

    Console.Write("Введите число >>> ");
    int num2 = Convert.ToInt16(Console.ReadLine());

    Console.Write("Введите число >>> ");
    int num3 = Convert.ToInt16(Console.ReadLine());

    if (num1 > num2 && num1 > num3) { 

        Console.WriteLine(num1 + " >>> большее");

    } else if (num2 > num1 && num2 > num3) {

        Console.WriteLine(num2 + " >>> большее");

    } else Console.WriteLine(num3 + " >>> большее");  
*/

// 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
    Console.Write("Введите число >>> ");
    int num1 = Convert.ToInt16(Console.ReadLine());
    
    // if (Convert.ToBoolean(num1 % 2)) {   // хотел просто "num1 % 2", но это не питон(
    //     Console.Write("Нечетное");
    // } else Console.Write("Четное");

    if (num1 % 2 == 0) {   // нормальная конструкция
        Console.Write("Четное");
    } else Console.Write("Нечетное");
*/

// 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
    Console.Write("Введите число >>> ");
    int n = Convert.ToInt16(Console.ReadLine());

    for (int i = 1; i < n; i++) {
        if (i % 2 == 0) {
            Console.WriteLine(i);
        }
    }
*/
