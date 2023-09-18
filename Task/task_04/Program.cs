/*
Напишите программу, которая на вход принимает трехзначное число и на выходе
показывает последнюю цифру этого числа. 

пример: 456 -> 6
        782 -> 2
        918 -> 8
*/



// моё
using System;
Console.Clear();

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Последняя цифра числа: {number % 10}");


// учитель
using System;
Console.Clear();

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int x = number % 10;
Console.WriteLine(x);





