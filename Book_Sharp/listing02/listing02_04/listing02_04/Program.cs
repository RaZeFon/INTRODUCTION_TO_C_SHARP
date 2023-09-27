/*
 Напишите программу, которая проверяет, попадает ли введёное пользователем число
в диапозон от 5 до 10 включительно.
*/


using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class RangeNumbers
{
    static void Main()
    {
        int number = int.Parse(Interaction.InputBox("Введите число", "Проверка на диапозон от 5 до 10"));
        if ((number <= 10) && (number >= 5)) MessageBox.Show($"число {number} входит в диапозон", "диапозон от 5 до 10");
        else MessageBox.Show($"Число {number} невошло в диапозон", "диапозон от 5 до 10");
    }
}



using System;
using static System.Console;

class RangeNumbers
{
    static void Main()
    {
        Title = "Проверка на диапозон от 5 до 10";
        Write("Введите число: ");
        int number = int.Parse(ReadLine());
        if ((number <= 10) && (number >= 5)) Write($"число {number} входит в диапозон ");
        else{
            Write($"Число {number} невошло в диапозон ");
        }
    }
}


