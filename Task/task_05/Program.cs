using System;
/*
Напишите программу, которая выводит случайное число из отрезка [10, 99]
и показывает наибольшую цифру числа.

например:   78 -> 8
            12 -> 2
            85 -> 8
*/

using System;
//позволяет использовать функции класса консоль без вызова самого класса
using static System.Console;

Clear();

int number = new Random().Next(10, 100);
int a1 = number / 10;
int a2 = number % 10;
if (a1 > a2){
    WriteLine($"{number} -> {a1}");
}
else{
    WriteLine($"{number} -> {a2}");
}





