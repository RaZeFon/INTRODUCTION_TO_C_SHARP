/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.

пример: 456 -> 5
        782 -> 8
        918 -> 1
*/

using System;
using static System.Console;
Clear();

Write("Введите трех значное число: ");
int threeDigitNumber = int.Parse(ReadLine());
WriteLine($"Второе число: {SecondNumber(threeDigitNumber)}");

int SecondNumber(int num){
    int result = (num % 100) / 10;
    return result;
}