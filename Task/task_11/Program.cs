/*
Напишите программу, которая по заданному номеру четверти, показывает
диапазон возможных координат точек в этой четверти (X и Y)

пример: 1 -> x>0; y>0                           ^y
        3 -> x<0; y<0                       2   |   1
        2 -> x<0; y>0                  ------------------->
                                            3   |   4     x
                                                |
*/


// моё
using System;
using static System.Console;
Clear();

Write("Введите координатную четверть: ");
int quarter = int.Parse(ReadLine());

if (quarter == 1){
    WriteLine($"{quarter} -> x>0; y>0");
}
if (quarter == 2){
    WriteLine($"{quarter} -> x<0; y>0");
}
if (quarter == 3){
    WriteLine($"{quarter} -> x<0; y<0");
}
if (quarter == 4){
    WriteLine($"{quarter} -> x>0; y<0");
}
else if ((quarter <= 0) || (quarter >= 5)){
    WriteLine("Такой четверти не существует!");
}

//============================================================================

// учитель
using System;
using static System.Console;
Clear();

Write("Введите координатную четверть: ");
int n = int.Parse(ReadLine());

if (n == 1)
{
    WriteLine("x>0; y>0");
}
if (n == 2)
{
    WriteLine("x<0; y>0");
}
if (n == 3)
{
    WriteLine("x<0; y<0");
}
if (n == 4)
{
    WriteLine("x>0; y<0");
}

//=======================================================================

//учитель
using System;
using static System.Console;
Clear();

Write("Введите координатную четверть: ");
int n = int.Parse(ReadLine());

//оператор ветвления
// оператору передаём нашу переменную
// служебное слово case определяет чему равна наша переменная
// например case равна 1 -> (case 1:)
switch(n)
{
    case 1: 
    {
        WriteLine("x>0; y>0");
        break;
        // и выведем служебное слово break 
        // которое говорит что на этом действия закончились
    }
    case 2:
    {
        WriteLine("x<0; y>0");
        break;
    }
    case 3:
    {
        WriteLine("x<0; y<0");
        break;
    }
    case 4:
    {
        WriteLine("x>0; y<0");
        break;
    }
    // у оператора switch есть условие по умолчанию default:
    // это условие отработает, если нет не одного совпавшего решения
    default:
    {
        WriteLine("Неверная четверть");
        break;
    }
}


// оператор switch удобно использовать, когда у вас изначально определён набор данных

