//программа, которая навход принимает 2 числа и выдает, какое число больше,а какое меньше
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
