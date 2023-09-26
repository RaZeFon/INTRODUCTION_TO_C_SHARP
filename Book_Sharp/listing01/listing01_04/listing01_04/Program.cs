/*
 Напишите программу, в которой пользователю предлогаеться ввести название месяца и количество дней в этом месяце. 
Программа выводит сообщение о том, что соответствующий месяц содержит указаное количество дней. Предложите 
версии программы для ввода и вывода  данных через консоль и спомощью диологовых окон.
*/


using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class MonthDay
{
    static void Main()
    {
        string month = Interaction.InputBox("Введите текущий месяц", "Введите месяц");
        string days = Interaction.InputBox("Ведите количество дней в месяце", "Количество дней");
        MessageBox.Show($"В {month} {days} дней");

    } 
}

//================================================================================

using System;
using static System.Console;

class MonthDay
{
    static void Main()
    {
        Clear();
        Title = "Данные о месяце";
        Write("Введите месяц ");
        string month = ReadLine();
        Write("Введите количество дней ");
        string days = ReadLine();
        WriteLine($"В {month} {days} дней");
    }
}
