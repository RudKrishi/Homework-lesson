// // Домашнее задание с урока 5.
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.


// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//     array[i]  = new Random().Next(1, 100);
//     }
// }

// int [] array = new int[100];
// FillArray(array);
// int index = 0;
// int a = 0;

// while(index < array.Length)
// {
//     if (array[index] % 2 == 0)
//     {    
//    index++;
//    a = a + 1;
//    }
// else
// {
// index++;
//     a=a+0;
// }
// }
// Console.WriteLine(a);

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


void FillArray(int[] array)
{

for (int i = 0; i < array.Length; i++)
{
    array[i]  = new Random().Next(1, 10);
}
}
int [] array = new int[9];
FillArray (array);
int index = 0;
int sum = 0;

while(index < array.Length)
{
    if (index % 2 == 1)
{
    sum = sum + array[index];
    index++;
}
    else
    {
        sum = sum + 0;
        index++;
    }
}

//Console.Write(array[index]);
Console.WriteLine(sum);




//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

