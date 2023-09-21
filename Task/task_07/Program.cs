using System.Reflection.PortableExecutable;
using System.IO.Enumeration;
using System.IO;
using System.Security.AccessControl;
/*
Напишите программу, которая будет на вход принимать два числа и выводить,
является ли второе число кратным первому. Если второе число не кратно числу
первому, то программа выводит остаток от деления.

пример: 34, 5 -> не кратно, остаток 4
        16, 4 -> кратно
*/


// моё
using System;
using static System.Console;
Clear();

Write("Введите первое число: ");
int number1 = int.Parse(ReadLine());
Write("Введите второе число: ");
int number2 = int.Parse(ReadLine());
Multiplicity(number1, number2);

void Multiplicity(int num1, int num2)
{
    if (num1 % num2 != 0){
        WriteLine($"Не кратно, остаток {num1 % num2}");
    }
    else{
        WriteLine("Кратно");
    }
}


// учитель
using System;
using static System.Console;
Clear();

Write("Введите первое число: ");
int a = int.Parse(ReadLine());
Write("Введите второе число: ");
int b = int.Parse(ReadLine());

if (a % b == 0)
{
    WriteLine("Кратно");
}
else
{
    WriteLine($"Не кратно {a % b}");
}



