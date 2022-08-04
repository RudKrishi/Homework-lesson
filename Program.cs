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
// int N2 = 0;
// int a2 = 0;
// int b2 = 0;
// int c2 = 0;
// int d2 = 0;
// int e = 0;
// int e2 = 0;
// int e3 = 0;

// Console.Write($"Введите пятизначное число: ");
// N = Convert.ToInt32(Console.ReadLine());
// if(N < 100000 && N > 10000)
// {
//     a = N / 10000;
//     b = N / 1000;
//     b1 = b % 10;
//     e = N / 100;
//     e2 = e / 10;
//     e3 = e2 % 10;
//     c = N % 100;
//     c1 = c / 10;
//     d = N % 10;

// if (a2 = d)
// {
//     if (b2 = c1)

// {
//     if (c2 = c1)
//     {
//         if (d2 = a)
//         {

 
// N2 = (a2 * 10000) + (b2 * 1000) + c2 + d2;
    
//     Console.WriteLine($" Введенное число N: {N}");
//     Console.WriteLine($" а {a}, b {b1}, c {c1}, d {d} ");
//     Console.WriteLine($" Перевернутое число N2: {N2}");
//      Console.WriteLine($" e{e}, e2{e2}, e3{e3}");
//             }
//     }
// }

// }
// }
// else
// {
//     Console.WriteLine($"Введено неправильное число ");
// }



//Задача 2.
//Напишите программу, которая принимает на вход координаты двух точек и
 //находит расстояние между ними в 3D пространстве.
double x1 = 0;
double y1 = 0;
double z1 = 0;
double x2 = 0;
double y2 = 0;
double z2 = 0;
double dis = 0;
Console.Write($"Задача 2.");
Console.Write($"Введите координаты для A: ");
//A

 x1 = Convert.ToInt32(Console.ReadLine());
 y1 = Convert.ToInt32(Console.ReadLine());
 z1 = Convert.ToInt32(Console.ReadLine());

 Console.Write($"Введите координаты для B: ");
//B
 x2 = Convert.ToInt32(Console.ReadLine());
 y2 = Convert.ToInt32(Console.ReadLine());
 z2 = Convert.ToInt32(Console.ReadLine());


 dis = Math.Sqrt(((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1)));


Console.Write($"Расстояние меджу А и И: {dis}");













//Задача 3. 
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// int N = 1;
// int i = 1;
// int a = 0;
// Console.Write($"Введите число: ");
// N = Convert.ToInt32(Console.ReadLine());

// while (i < N)
// {
//     a = N - 1;
//     a = a*a*a;
//     i++;
//     Console.WriteLine(a);
    
// }


///////////////////////////////////////////////////////////////////////////////////////////////////
//  // Домашнее задание с Урока 2.(ВЫПОЛНЕНО)
//  //Массивы и Функции в программировании.(блок-схемы в папке ex02.drawio.png)
//  // Задача 1. Напишите программу, которая принимает на вход трёхзначное число 
//  //и на выходе показывает вторую цифру этого числа.

// int number = new Random().Next(10,1000);
// int x = number % 100;
// int y = x / 10;
//  Console.WriteLine($"Домашнее задание с Урока 2");
//  Console.WriteLine($"Задача 1. number: {number}");
//  Console.WriteLine($"y = {y}");
 

// //Задача 2: Напишите программу, которая выводит третью цифру заданного числа или 
// //сообщает, что третьей цифры нет.


// int number1 = new Random().Next(10,1000);
// int z1 = number1 % 10;
// if(number1 < 100)
// {
//     Console.WriteLine($"Задача 2. number1: {number1}");
//     Console.WriteLine($"Третьей цифры нет");
    
// }

// else
// {

// Console.WriteLine($"Задача 2. number1: {number1}");
// Console.WriteLine($"z1 = {z1}");
// }

// //Задача 3. 
// //Напишите программу, которая принимает на вход цифру,
// //обозначающую день недели, и проверяет, является ли этот день выходным.

// int number2 = new Random().Next(-10,10);
// if (number2 >1 && number2 < 6)
// {
// Console.WriteLine($"Домашнее задание с Урока 2. Задача 3.");
//  Console.WriteLine($"number2: {number2}");
// Console.WriteLine($"Это рабочий день недели");
// }

//     if(number2 ==7)
//     {
//     Console.WriteLine($"Домашнее задание с Урока 2. Задача 3.");
//      Console.WriteLine($"number2: {number2}");
//     Console.WriteLine($"Это выходной день недели");
//     }
//     if(number2 ==6)
//     {
//     Console.WriteLine($"Домашнее задание с Урока 2. Задача 3.");
//      Console.WriteLine($"number2: {number2}");
//     Console.WriteLine($"Это выходной день недели");
//     }
//     if(number2 < 1 && number2 > 7)
// {
//    Console.WriteLine($"Домашнее задание с Урока 2. Задача 3.");
//    Console.WriteLine($"number2: {number2}");
//    Console.WriteLine($"Такого дня недели нет"); 
// }



//  // Домашнее задание с Урока 1(ВЫПОЛНЕНО)
// //Задача 1. программа, которая навход принимает 2 числа и выдает, какое число больше,а какое меньше
// int a = new Random().Next(-10,10);
// int b = new Random().Next(-10,10);
// int max=0;
// int min=0;
// if (a < b)
// {
//     min=a;
//     max=b;
// Console.WriteLine($"Домашнее задание с Урока 1. Задача 1. Из чисел {a} и {b} max = {max}, min = {min}");
// }
// else
// {
// max=a;
// min=b;
// Console.WriteLine($"Задача 1. Из чисел {a} и {b} max = {max}, min = {min}");
// }

// //Задача 2. Программа, которая принимает на вход 3 числа и выбирает максимальное

// int d = new Random().Next(1,10);
// int e = new Random().Next(1,10);
// int f = new Random().Next(1,10);

// if ((d>e)&&(d>f))
// {
//     max = d;
// Console.WriteLine($"Задача 2. Максимльное из чисел {d} и {e} и {f} max = {max}");
// }
// else
// {
//     if (d<f)
//     {
//     max = f;
// Console.WriteLine($"Задача 2. Максимльное из чисел: {d} и {e} и {f} max = {max}");
//     }
//     if(e>f)
//     max = e;
//     Console.WriteLine($"Задача 2. Максимльное из чисел: {d} и {e} и {f} max = {max}");
// }


// // Задача 3. Программа, которая выдает четное ли число.

// int N = new Random().Next(1,100);
// if (N % 2 == 0)
//  {Console.WriteLine($"Задача 3: {N}  - четное число");
//  }
//  else 
//  {
//     Console.WriteLine($"Задача 3: {N}  - нечетное число");
//  }

