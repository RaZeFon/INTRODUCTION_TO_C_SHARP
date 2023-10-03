/*
Напишите программу, которая вычисляет третий бит справа в двоичном представлении числа,
введеного пользователем. Число вводится в десятичном (обычном) представлении. В программе используется
оператор побитового сбвига
*/


using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class BinarySystem
{
    static void Main()
    {
        int number = int.Parse(Interaction.InputBox("Введите число ", "Преобразования числа в двоичною систему исчисления")) >> 2;
        int number_bit = number & 1;
        MessageBox.Show($"Третий бит = {number_bit}", "третий бит");
    }
}


using System;
using static System.Console;

class BinarySystem
{
    static void Main()
    {
        Title = "третий бит справа в двоичном представлении числа";
        Write("Введите число: ");
        int number = (int.Parse(ReadLine()) >> 2) & 1;
        WriteLine($"Трений бит с права = {number} ");
    }
}
