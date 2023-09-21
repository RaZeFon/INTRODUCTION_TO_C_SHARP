/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно
одновременно 7 и 23.

пример: 14 -> Нет
        46 -> Нет
        161 -> Да
*/


// моё
using System;
using static System.Console;
Clear();

WriteLine("Проверка кратности на 7 и 23");
Write("Введите число для проверки: ");
int number = int.Parse(ReadLine());
Multiplicity(number);

void Multiplicity(int num){
    if ((num % 7 == 0) && (num % 23 == 0)){
        WriteLine("Да");
    }
    else {
        WriteLine("Нет");
    }
}


// учитель
using System;
using static System.Console;
Clear();

Write("Введите число для проверки: ");
int number = int.Parse(ReadLine());

if ((number % 7 == 0) && (number % 23 == 0))
{
    WriteLine($"{number} -> Да");
}
else
{
    WriteLine($"{number} -> Нет");
}



