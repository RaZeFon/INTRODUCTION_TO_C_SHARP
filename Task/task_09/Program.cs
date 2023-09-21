/*
Напишите программу, которая принимает на вход два числа и проверяет, является 
ли одно число квадратом другого.

пример: a = 5; b = 25 -> b квадрат a
        a = 9; b = 3  -> a квадрат b
        a = 3; b = 2  -> не являются
*/


// моё
using System;
using static System.Console;

Clear();
Write("Введите число А: ");
int numberA = int.Parse(ReadLine());
Write("Введите число В: ");
int numberB = int.Parse(ReadLine());
SquareNumber(numberA, numberB);

void SquareNumber(int numA, int numB){
    if (numA * numA == numB) WriteLine($"b = {numB} квадрат a = {numA}");
    if (numB * numB == numA) WriteLine($"a = {numA} квадрат b = {numB}");
    else {
        WriteLine("не является");
    }
}


// учитель
using System;
using static System.Console;
Clear();

Write("Введите число А: ");
int A = int.Parse(ReadLine());
Write("Введите число В: ");
int B = int.Parse(ReadLine());

if (B * B == A )
{
    WriteLine("A является квадратом В");
}
else
{
    if (Math.Pow(A, 2) == B)
    {
        WriteLine("B является квадратом А");
    }
    else
    {
        WriteLine("не являются");
    }
}
