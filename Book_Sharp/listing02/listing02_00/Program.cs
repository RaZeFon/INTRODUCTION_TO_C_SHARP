﻿/*
static void Main(){
    // переменная объявлена в главном методе
    int A;
    // команды 
    { // начало внутреннего блока
        // переменная объявлена  во внутреннем блоке
        int B;
        // команды
    } // завершение внутреннего блока
    // команды 
}
*/

//=========================================================

/*
int A, B, C;
A = (A= (A = 3) + (B = 5) - (C = 7 - B)) + (A = A + (B = B + 2) * (C = C - 3));
*/

//==========================================================

/*
// проверка на четность
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class OddEvenDemo{
    static void Main(){
        //целочисленные переменные
        int number, reminder;
        // считывание целого числа
        number = Int32.Parse(Interaction.InputBox(
            //текс в окне
            "Введите целое число: ",
            //название окна
            "Проверка: ")
        );
        // вычисление остатков от деления на 2:
        reminder = number % 2;
        string txt = "Вы ввели ";
        // использован тернарный оператор
        txt += (reminder == 0 ? "четное" : "нечетное" + " число!");
        MessageBox.Show(txt);
    }
}
*/

//==================================================================

// количество сотен в числе

using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class HandredsDemo
{
    static void Main()
    {
        // целочисленные переменые
        int number, hundreds;
        // считывание целого числа
        number = Int32.Parse(Interaction.InputBox(
            // надпись над полем ввода
            "Введите целое число",
            // заголовок окна
            "Количество сотен"
            )
        );
        // количество сотен в числе (для целочисленных операторов деление выполняеться нацело)
        hundreds = number / 100 % 10;
        // текстовая переменая
        string txt = "В этом числе " + hundreds + " сотен!";
        // Отображение окна с сообщением (аргументы метода - сообщение ми заголовок окна)
        MessageBox.Show( txt, " Сотни");
    }
}