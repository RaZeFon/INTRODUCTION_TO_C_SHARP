/*
Напишите программу, программу для вычисления суммы двух чисел. Оба числа водятся пользователем
Для вычисления суммы используйте оператор +. Предложите два варианта программы: программу, в которой
данные вводятся и выводятся с помощью диологовых окон, и программу в которой используеться консольвый 
ввод и вывод данных.
*/


using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class SumNumber
{
    static void Main()
    {
        int number1 = Int32.Parse(Interaction.InputBox("Ведите первое число", "Сумма двух чисел"));
        int number2 = Int32.Parse(Interaction.InputBox("Ведите второе число", "Сумма двух чисел"));
        MessageBox.Show($"Сумма = {number1 + number2}", "Результат");
    }
}



using System;
using static System.Console;

class SumNumber
{
    static void Main()
    {
        Clear();
        Title = "Сумма двух чисел";
        Write("Введите первое число: ");
        int number1 = int.Parse(ReadLine());
        Write("Введите второе число: ");
        int number2 = int.Parse(ReadLine());
        WriteLine($"Сумма = {number1 + number2}");
    }
}

