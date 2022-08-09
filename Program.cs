// // Домашнее задание с урока 4.
// Зачада 1. Задача 25: Напишите метод, который 
//принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int a = 0;
int b = 0;
int N = 0;
Console.Write($"Введите возводимое число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число, в которое будем возводить: ");
b = Convert.ToInt32(Console.ReadLine());
N = Convert.ToInt32(Math.Pow(a, b));
Console.WriteLine($"Итоговое  число: {N}");
