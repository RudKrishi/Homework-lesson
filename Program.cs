// Домашнее задание с урока 3.(блок-схемы в папке ex03.drawio.png)
//Задача 1. Напишите программу, 
//которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// int N = 0;
// int a = 0;
// int b = 0;
// int b1 = 0;
// int c = 0;
// int c1 = 0;
// int d = 0;
// int e = 0;
// int e1 = 0;

// Console.Write($"Введите пятизначное число: ");
// N = Convert.ToInt32(Console.ReadLine());

// if(N < 100000 && N > 10000)
// {
//     a = N / 10000;
//     b = N / 1000;
//     b1 = b % 10;
//     e = N / 100;
//     e1 = e % 10;
//     c = N % 100;
//     c1 = c / 10;
//     d = N % 10;

//     if (a == d)
//     {
//         Console.WriteLine($"Введенное число является палиндромом");
//     }
//         else
//         {
//             Console.WriteLine($"Введенное число НЕ является палиндромом");
//         }

//     }

// else
// {
//     Console.WriteLine($"Введено неправильное число ");
// }





//Задача 2.
//Напишите программу, которая принимает на вход координаты двух точек и
 //находит расстояние между ними в 3D пространстве.
// double x1 = 0;
// double y1 = 0;
// double z1 = 0;
// double x2 = 0;
// double y2 = 0;
// double z2 = 0;
// double dis = 0;
// Console.Write($"Задача 2.");
// Console.Write($"Введите координаты для A: ");
// //A

//  x1 = Convert.ToInt32(Console.ReadLine());
//  y1 = Convert.ToInt32(Console.ReadLine());
//  z1 = Convert.ToInt32(Console.ReadLine());

//  Console.Write($"Введите координаты для B: ");
// //B
//  x2 = Convert.ToInt32(Console.ReadLine());
//  y2 = Convert.ToInt32(Console.ReadLine());
//  z2 = Convert.ToInt32(Console.ReadLine());


//  dis = Math.Sqrt(((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1)));


// Console.Write($"Расстояние меджу А и И: {dis}");









//Задача 3. 
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int N = 0;
int i = 1;
int a = 0;
Console.Write($"Введите число: ");
N = Convert.ToInt32(Console.ReadLine());
while (i <= N)
{
    a = Convert.ToInt32(Math.Pow(i, 3));
     i++;
        Console.WriteLine(a);
}
   
 
