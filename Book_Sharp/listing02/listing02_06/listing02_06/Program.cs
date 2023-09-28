/*
 Напишите программу, которая проверяет вторую справа цифру в восьмеричном представлении числа,
введеного пользователем. Число вводится в десятичном (обычном) представлении.
*/


using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;


class OctalSystem
{
    static void Main()
    {
        int number = Int32.Parse(Interaction.InputBox("Введите число", "Перевод в восьмеричную систему счисления"));
        string result_str = string.Empty;
        while (number > 0)
        {
            result_str = Convert.ToString(number % 8) + result_str;
            number /= 8;
        }
        int number2 = (Int32.Parse(result_str) / 10 % 10);
        MessageBox.Show($"Вторая цифра {number2} востеричного числа {result_str}", "Решение");

    }
}