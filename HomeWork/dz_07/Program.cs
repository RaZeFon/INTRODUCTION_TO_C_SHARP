/*
Напишите программу, которая принимает на вход цифру, обозначающую 
день недели, и проверяет, является ли этот день выходным.

пример: 6 -> да
        7 -> да
        1 -> нет
*/

using System;
using static System.Console;
Clear();

Write("Введите число дня недели: ");
int day = int.Parse(ReadLine());
if ((day <= 0) || (day >= 8)){   //оператор выполняется || если верно хотя бы одно условие
    WriteLine("Неверный день недели");
}
DayWeeks(day);

void DayWeeks(int day_number){
    if ((day_number >= 1) && (day_number <= 5)){
        WriteLine("НЕТ это будний день");
    }
    else if ((day_number >= 6) && (day_number <= 7)){
        WriteLine("ДА это выходной день");
    }
}