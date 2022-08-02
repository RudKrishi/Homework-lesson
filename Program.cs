 // Домашнее задание с Урока 2.
 //Массивы и Функции в программировании.(блок-схемы в папке ex02.drawio.png)
 // Задача 1. Напишите программу, которая принимает на вход трёхзначное число 
 //и на выходе показывает вторую цифру этого числа.

int number = new Random().Next(10,1000);
int x = number % 100;
int y = x / 10;
 Console.WriteLine($"Домашнее задание с Урока 2");
 Console.WriteLine($"Задача 1. number: {number}");
 Console.WriteLine($"y = {y}");
 

//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


int number1 = new Random().Next(10,1000);
int z1 = number1 % 10;
if(number1 < 100)
{
    Console.WriteLine($"Задача 2. number1: {number1}");
    Console.WriteLine($"Третьей цифры нет");
    
}

else
{

Console.WriteLine($"Задача 2. number1: {number1}");
Console.WriteLine($"z1 = {z1}");
}

//Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.

int number2 = new Random().Next(-10,10);
if (number2 >1 && number2 < 6)
{
Console.WriteLine($"Домашнее задание с Урока 2. Задача 3.");
 Console.WriteLine($"number2: {number2}");
Console.WriteLine($"Это рабочий день недели");
}

    if(number2 ==7)
    {
    Console.WriteLine($"Домашнее задание с Урока 2. Задача 3.");
     Console.WriteLine($"number2: {number2}");
    Console.WriteLine($"Это выходной день недели");
    }
    if(number2 ==6)
    {
    Console.WriteLine($"Домашнее задание с Урока 2. Задача 3.");
     Console.WriteLine($"number2: {number2}");
    Console.WriteLine($"Это выходной день недели");
    }
    if(number2 < 1 && number2 > 7)
{
   Console.WriteLine($"Домашнее задание с Урока 2. Задача 3.");
   Console.WriteLine($"number2: {number2}");
   Console.WriteLine($"Такого дня недели нет"); 
}










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

