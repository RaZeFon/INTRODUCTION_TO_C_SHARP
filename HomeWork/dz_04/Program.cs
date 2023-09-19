
/*
Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.

пример: 5 -> 2, 4
        8 -> 2, 4, 6, 8
*/

using System;
Console.Clear();

Console.Write("Введите число: ");
int numberN = int.Parse(Console.ReadLine());
int i = 1;
while (i <= numberN){
    if (i % 2 == 0) {
        Console.Write($"{i} ");
        i++;
    }
    else{
        i++;
    }
}