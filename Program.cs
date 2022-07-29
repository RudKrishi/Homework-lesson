//Задача 1. программа, которая навход принимает 2 числа и выдает, какое число больше,а какое меньше
int a = new Random().Next(-10,10);
int b = new Random().Next(-10,10);
int max=0;
int min=0;
if (a < b)
{
    min=a;
    max=b;
Console.WriteLine($"Из чисел {a} и {b} max = {max}, min = {min}");
}
else
{
max=a;
min=b;
Console.WriteLine($"Из чисел {a} и {b} max = {max}, min = {min}");
}



//Задача 2. Программа, которая принимает на вход 3 числа и выбирает максимальное

int d = new Random().Next(1,10);
int e = new Random().Next(1,10);
int f = new Random().Next(1,10);

if ((d>e)&&(d>f))
{
    max = d;
Console.WriteLine($"Максимльное из чисел {d} и {e} и {f} max = {max}");
}
else
{
    if (d<f)
    {
    max = f;
Console.WriteLine($"Максимльное из чисел {d} и {e} и {f} max = {max}");
    }
    if(e>f)
    max = e;
    Console.WriteLine($"Максимльное из чисел {d} и {e} и {f} max = {max}");
}
