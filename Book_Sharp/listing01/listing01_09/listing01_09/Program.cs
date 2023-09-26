/*
Напишите программу, в которой пользователь водит число, а программой отображается последовательность
из трех чисел: число на единицу меньше введеного, веденое число и число на единицу больше введеного.
Предложите версию программы с консольным вводом и выводом данных, а также версию программы, в
которой ввод и вывод выполняются спомощью диалоговых окон.
*/


using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class Numbers
{
    static void Main()
    {
        int number = Int32.Parse(Interaction.InputBox("Введите число: ", "Ввод числа"));
        MessageBox.Show($"{number - 1}, {number}, {number + 1}");
    }
}


using System;
using static System.Console;

class Numbers
{
    static void Main()
    {
        Clear();
        Write("Введите число: ");
        int number = int.Parse(ReadLine());
        WriteLine($"{number - 1}, {number}, {number + 1}");
    }
}

