/*
 Напишите программу, которая проверяет, удовлетворяет ли введёное пользователем число 
следующим критериям: при делении на 5 остаток получается 2, а при делении на 7 
в остатке получается 1.
*/


using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class DivisionRemaider
{
    static void Main()
    {

        int number = Int32.Parse(Interaction.InputBox("Проверка:\n" +
            "при делении на 5 остаток 2\n" +
            "при делении на 7 остаток 1", "Проверка вводимого числа"));
        string result_str = ((number % 5 == 2) && (number % 7 == 1) ? "удовлетворяет условиям" : "непрошло проверку");
        MessageBox.Show($"Чило {number} {result_str}", "Результат проверки");
    }
}


using System;
using static System.Console;

class DivisionRemainder
{
    static void Main()
    {
        Title = "Проверка соответствия: А:5=2(остаток) и А:7=1(остаток)";
        Write("Введите число \"А\" для проверки: ");
        int number_A = int.Parse(ReadLine());
        string resuit_str = ((number_A % 7 == 1) && (number_A % 5 == 2) ? "удовлетворяет условиям" : "непрошло проверку");
        WriteLine($"Число {number_A} {resuit_str}");
    }
}
