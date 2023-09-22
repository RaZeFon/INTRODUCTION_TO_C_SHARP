/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до (N)

пример: 5 -> 1, 4, 9, 16, 25
        2 -> 1, 4
*/


// моё
using System;
using static System.Console;
Clear();

Write("Введите число N: ");
int numberN = int.Parse(ReadLine());
Write($"{numberN} -> ");
SquareNumber(numberN);

void SquareNumber(int numN){
    for (int i = 1; i <= numN; i++){
        Write($"{i * i} ");
    }
}


// учитель
using System;
using static System.Console;
Clear();

Write("Введите N: ");
int N = int.Parse(ReadLine());

for(int i = 1; i <= N; i++)
{
    Write($"{i * i} ");
}




