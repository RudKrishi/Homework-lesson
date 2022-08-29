// // Домашнее задание с урока 6.
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.Write("Введите числа(через пробел): ");
// int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;
 
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         count++;
//     }
// }
 
// Console.WriteLine($"Количество чисел: {count}");



///////////////////////////////////////////////////////////////////////////////////////////////////////////
// // Домашнее задание с урока 7.

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


double[,] a = new double[3, 4];
Random random = new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        a[i, j] = random.Next(100);
        Console.Write("{0,3}", a[i, j]);
    }
    Console.WriteLine();
}