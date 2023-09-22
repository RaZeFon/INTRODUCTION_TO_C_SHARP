﻿/*
Напишите программу, которая принимает на входе координаты точки (X и Y),
причём X != 0 и Y != 0 и выдает номер четверти плоскости, в которой
находиться эта точка.

пример: -7; 8 -> 2                                      ^y
        3; 10 -> 1                                  2   |   1
        -1; -1 -> 3                         ------------------------>
                                                    3   |   4       x
                                                        |
*/


using System;
using static System.Console;
Clear();

Write("Введите координату X: ");
int x = int.Parse(ReadLine());
Write("Введите координату Y: ");
int y = int.Parse(ReadLine());

if (x > 0 && y > 0)
{
    WriteLine("1 координатная четверть");
}
if (x < 0 && y > 0)
{
    WriteLine("2 координатная четверть");
}
if (x < 0 && y < 0)
{
    WriteLine("3 координатная четверть");
}
if (x > 0 && y < 0)
{
    WriteLine("4 координатная четверть");
}


                                                        
