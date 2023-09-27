/*
 Напишите программу, которая проверяет, сколько тысяч во введеном пользователем числе
(определяется четвертая цифра справа в десятичном представлении числа)
*/


using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class Thousands
{
    static void Main()
    {
        int number = int.Parse(Interaction.InputBox("Введите число", "Проверка сколько тысяч в числе"));
        MessageBox.Show($"тысяч = {number / 1000 % 10}", "Результат");
    }
}


using System;
using static System.Console;

class Thousands
{
    static void Main()
    {
        Title = "Cколько тысяч во введеном пользователем числе";
        Write("Введите число: ");
        int number = int.Parse(ReadLine());
        WriteLine($"{number / 1000 % 10} тысяч в числе");
    }
}


