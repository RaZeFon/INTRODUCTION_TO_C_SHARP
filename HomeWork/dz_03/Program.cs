
/*
Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

пример: 4 -> да
        -3 -> нет
        7 -> нет
*/

using System;
Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0) Console.WriteLine("Да");
else Console.WriteLine("Нет");









