
/*
Напишите программу, которая на вход принимает одно число (N), а на выходе
показывает все целые числа в промежутке от -N до N.

пример: 4 -> -4, -3, -2, -1, 0, 1, 2, 3, 4
        2 -> -2, -1, 0, 1, 2
*/


// моё
using System;
Console.Clear();

Console.Write("Введите число N: ");
int number_N = int.Parse(Console.ReadLine());
if (number_N < 0) number_N *= -1;
int minus_N = number_N * -1;

while (minus_N <= number_N)
{
    Console.Write($"{minus_N} ");
    minus_N++;
}    


// учитель
using System;

Console.Clear();
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());
int B = -N;

while (B <= N)
{
    Console.Write($"{B} ");
    B++;
}
