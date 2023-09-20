/*
Напишите программу, которая выводит случайное трехзначное число
и удаляет вторую цифру этого числа.

пример: 456 -> 46
        782 -> 72
        918 -> 98
*/


// моё
using System;
using static System.Console;
Clear();

int number = new Random().Next(100, 1000);
int hundreds = number / 100;
int units = number % 10;
WriteLine($"{number} -> {hundreds * 10 + units}");


// учитель
using System;
using static System.Console;

Clear();
int number = new Random().Next(100, 1000);
int a1 = number / 100;
int a2 = number % 10;
WriteLine($"{number} -> {a1 * 10 + a2}");


//  учитель 2 вариант
using System;
using static System.Console;

Clear();
int number = new Random().Next(100, 1000);
WriteLine($"{number} -> {(number / 100) * 10 + number % 10}");
