/*
Напишите программу, которая будет выдавать название дня недели по заданному номеру.
при помощи оператора switch

пример: 3 -> среда
        5 -> пятница
*/

using System;
using static System.Console;
Clear();

Write("Введите номер дня недели: ");
int day = int.Parse(ReadLine());

switch(day){
    case 1:{
        WriteLine("Понедельник");
        break;
    }
    case 2:{
        WriteLine("Вторник");
        break;
    }
    case 3:{
        WriteLine("Среда");
        break;
    }
    case 4:{
        WriteLine("Четверг");
        break;
    }
    case 5:{
        WriteLine("Пятница");
        break;
    }
    case 6:{
        WriteLine("Суббота");
        break;
    }
    case 7:{
        WriteLine("Воскресенье");
        break;
    }
    default:{
        WriteLine("Неверный день недели!");
        break;
    }

}



