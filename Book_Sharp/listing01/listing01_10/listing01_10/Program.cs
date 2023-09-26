/*
Напишите программу, в которую пользователь вводит два числа, а программой 
вычисляеться и отображается сумма и разность этих чисел. Предложите варианты
программы с использованием консольного ввода вывода данных и ввода вывода данных
с помощью диалоговых окон.
*/


using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class Result
{
    static void Main()
    {
        int number1 = Int32.Parse(Interaction.InputBox("Введите первое число", "Ввод чисел"));
        int number2 = Int32.Parse(Interaction.InputBox("Введите второе число", "Ввод чисел"));
        MessageBox.Show($"Сумма = {number1 + number2}, Разность = {number1 - number2}");
    }
}


using System;
using static System.Console;

class Result
{
    static void Main()
    {
        Clear();
        Title = "Ввод чисел";
        Write("Введите первое число: ");
        int number1 = int.Parse(ReadLine());
        Write("Введите второе число: ");
        int number2 = int.Parse(ReadLine());
        WriteLine($"Сумма = {number1 + number2}, Разность = {number1 - number2}");
    }
}


