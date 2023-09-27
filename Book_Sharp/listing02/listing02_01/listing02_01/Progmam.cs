/*
 Напишите программу, которя проверяет, делиться ли введёное пользователем число на 3.
*/


using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class DivisionThree
{
    static void Main()
    {
        int number = Int32.Parse(Interaction.InputBox("Проверка делится ли число на 3", "Проверка числа"));
        string result = (number % 3 == 0 ? "Делиться на 3" : "Неделиться на 3");
        MessageBox.Show($"Число {number} {result}");
    }
}


using System;
using static System.Console;

class DivisionThree
{
    static void Main()
    {
        Title = "Проверка делится ли число на 3";
        Write("Введите число: ");
        int number = int.Parse(ReadLine());
        string result_str = (number % 3 == 0 ? "Делиться на 3" : "Неделится на 3");
        WriteLine($"{number} {result_str}");
}
}