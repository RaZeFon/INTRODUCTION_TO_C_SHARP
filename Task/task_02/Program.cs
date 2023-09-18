
/*
Напишите программу, которая будет выдавать название дня недели по заданному номеру.

пример: 3 -> среда
        5 -> пятница
*/

// моё решение
using System;
Console.Clear();

Console.Write("Введите день недели числом: ");
int numberDay = int.Parse(Console.ReadLine());

if ((0 < numberDay)&&(numberDay < 8))
{
    if (numberDay == 1) Console.WriteLine("Понедельник");
    if (numberDay == 2) Console.WriteLine("Вторник");
    if (numberDay == 3) Console.WriteLine("Среда");
    if (numberDay == 4) Console.WriteLine("Четверг");
    if (numberDay == 5) Console.WriteLine("Пятница");
    if (numberDay == 6) Console.WriteLine("Суббота");
    if (numberDay == 7) Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Неверный диапазон чисел");
}


// учитель
using System;
Console.Clear();

Console.Write("Введите номер дня недели ");
int number = int.Parse(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("Понедельник");
}
if (number == 2)
{
    Console.WriteLine("Вторник");
}
if (number == 3)
{
    Console.WriteLine("Среда");
}
if (number == 4)
{
    Console.WriteLine("Четверг");
}
if (number == 5)
{
    Console.WriteLine("Пятница");
}
if (number == 6)
{
    Console.WriteLine("Суббота");
}
if (number == 7)
{
    Console.WriteLine("Воскресенье");
}
if (number < 1 || number > 7)
{
    Console.WriteLine("Введен неверный номер дня недели");
}
