/*
Напишите программу, которая вычисляет третий бит справа в двоичном представлении числа,
введеного пользователем. Число вводится в десятичном (обычном) представлении. В программе используется
оператор побитового сбвига
*/

/*
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class BinarySystem
{
    static void Main()
    {
        int number = int.Parse(Interaction.InputBox("Введите число ", "Преобразования числа в двоичною систему исчисления"));
        string result_str = string.Empty;
        while (number > 0)
        {
            result_str = Convert.ToString(number % 2) + result_str;
            number /= 2;
        }
        int number2 = (Convert.ToInt32(result_str) >> 2) % 10;
        MessageBox.Show($"(10) = {number} -> (2) = {result_str} = 3 бит = {number2}", "третий бит");
    }
}
*/

using System;
using System.Runtime.InteropServices;
using static System.Console;

class BinarySystem
{
    static void Main()
    {
        Title = "третий бит справа в двоичном представлении числа";
        Write("Введите чиссло: ");
        int number = int.Parse(ReadLine());

        /*
        int number = int.Parse(ReadLine());
        WriteLine(number);
        string result_str = string.Empty;
        while (number > 0)
        {
            result_str = Convert.ToString(number % 2) + result_str;
            number /= 2;
        }
        int number2 = Convert.ToInt32(result_str);
        int result = (number2 << 10) % 10;
        WriteLine($"(2) = {result_str} >> 2 {number2}= 3 бит = {result}", "третий бит");
        */
    }
}