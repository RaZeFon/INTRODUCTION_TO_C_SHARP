
/*
Напишите программу,которая на вход принимает два числа и проверяет, является ли первое
число квадратом второго.

пример:     a = 25, b = 5 -> да
            a = 2, b = 10 -> нет
            a = 9, b = -3 -> да
            a = -3, b = 9 -> нет
*/

// моё 
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberB * numberB == numberA) Console.WriteLine("Да");
else Console.WriteLine("Нет");


// учитель
using System;
Console.Clear();

Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число В: ");
int B = int.Parse(Console.ReadLine());

if (B * B == A)
{
    Console.WriteLine("A является квадратом В");
}
else
{
    Console.WriteLine("A не является квадратом В");
}




