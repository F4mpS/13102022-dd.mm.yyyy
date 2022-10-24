// 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.Write("Enter num >>> ");
// int num = Convert.ToInt32(Console.ReadLine());

// if ((num / 10000) == (num % 10) && ((num / 1000) % 10) == ((num / 10) % 10))
// {
//     Console.WriteLine("Yes");
// } else Console.WriteLine("No");

// 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

// int[] A = new int[3];
// for (int i = 0; i < 3; i++){
//     Console.Write($"Enter {i + 1} coordinate >>> ");
//     A[i] = Convert.ToInt32(Console.ReadLine());
// }

// int[] B = new int[3];
// for (int i = 0; i < 3; i++){
//     Console.Write($"Enter {i + 1} coordinate >>> ");
//     B[i] = Convert.ToInt32(Console.ReadLine());
// }

// int x = 0;
// int y = 1;
// int z = 2;
// double distance = Math.Sqrt( Math.Pow((B[x] - A[x]), 2) + Math.Pow((B[y] - A[y]), 2) + Math.Pow((B[z] - A[z]), 2) );
// Console.WriteLine(distance);

// 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.Write("Enter num >>> ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Число\tКуб");

// for (int i = 1; i <= n; i++) {
//     Console.WriteLine("{0}\t{1}", i, Math.Pow(i, 3));
// }