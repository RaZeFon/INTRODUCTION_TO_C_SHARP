/* 
 Напишите программу, которая проверяет, удовлетворяет ли введеное пользователем число следующим
 критериям: число делится на 4, и при этом оно не меньше 10.
*/


using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class CheckNumber
{
    static void Main()
    {
        int number = Int32.Parse(Interaction.InputBox("Проверяем делится ли число на 4\n и при этом оно должно быть не меньше 10", "Проверка"));
        if (number < 10) MessageBox.Show($"Число {number} меньше 10", "Завершение работы");
        else {
            string result_str = (number % 4 == 0) ? "делится на 4" : "неделится на 4";
            MessageBox.Show($"Число {number} {result_str}");
        }
    }
}



using System;
using static System.Console;

class CheckNumber
{
    static void Main()
    {
        Clear();
        Title = "Проверка числа";
        WriteLine("Проверяем что число делится на 4, и при этом оно не меньше 10");
        Write("Введите число: ");
        int number = int.Parse(ReadLine());
        if (number < 10) Write($"{number} меньше 10 ");
        else
        {
            string result_str = (number % 4 == 0) ? "делится на 4 " : "неделится на 4 ";
            Write($"{number} {result_str}");
        }
    }
}

