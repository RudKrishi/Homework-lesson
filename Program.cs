 // Домашнее задание с Урока 2. Массивы и Функции в программировании.
 // Задача 1 .Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = new Random().Next(10,1000);
int x = number % 100;
int y = x / 10;
 Console.WriteLine($"Домашнее задание с Урока 2. Задача 1. number {number}");
 Console.WriteLine($"y = {y}");
 



















 // Домашнее задание с Урока 1(ВЫПОЛНЕНО)
//Задача 1. программа, которая навход принимает 2 числа и выдает, какое число больше,а какое меньше
int a = new Random().Next(-10,10);
int b = new Random().Next(-10,10);
int max=0;
int min=0;
if (a < b)
{
    min=a;
    max=b;
Console.WriteLine($"Домашнее задание с Урока 1. Задача 1. Из чисел {a} и {b} max = {max}, min = {min}");
}
else
{
max=a;
min=b;
Console.WriteLine($"Задача 1. Из чисел {a} и {b} max = {max}, min = {min}");
}



//Задача 2. Программа, которая принимает на вход 3 числа и выбирает максимальное

int d = new Random().Next(1,10);
int e = new Random().Next(1,10);
int f = new Random().Next(1,10);

if ((d>e)&&(d>f))
{
    max = d;
Console.WriteLine($"Задача 2. Максимльное из чисел {d} и {e} и {f} max = {max}");
}
else
{
    if (d<f)
    {
    max = f;
Console.WriteLine($"Задача 2. Максимльное из чисел: {d} и {e} и {f} max = {max}");
    }
    if(e>f)
    max = e;
    Console.WriteLine($"Задача 2. Максимльное из чисел: {d} и {e} и {f} max = {max}");
}


// Задача 3. Программа, которая выдает четное ли число.

int N = new Random().Next(1,100);
if (N % 2 == 0)
 {Console.WriteLine($"Задача 3: {N}  - четное число");
 }
 else 
 {
    Console.WriteLine($"Задача 3: {N}  - нечетное число");
 }

