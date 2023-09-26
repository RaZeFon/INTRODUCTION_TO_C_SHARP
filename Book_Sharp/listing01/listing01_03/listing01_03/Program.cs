/*
Напишите программу, в которой пользователь последовательно водит название 
текущего дня недели, название месяца и дату (номер дня в месяце). Программа 
выводит сообщение о сегодняшней дате (день недели, дата, месяц). Используйте 
консольный ввод и вывод данных. Предложите версию программы, в которой для ввода 
и вывода данных используются диалоговые окна.
*/


using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class DateDay
{
    static void Main()
    {
        string day, date, month;
        day = Interaction.InputBox("Сегодняшний день? ", "Введите день недели");
        date = Interaction.InputBox("Сегодняшнее число? ", "Ведите дату");
        month = Interaction.InputBox("Текущий месяц? ", "Введите месяц");
        MessageBox.Show($"{day} {date} {month}");
    }
}


using System;

class DataDay
{
    static void Main()
    {
        Console.Clear();
        Console.Title = "Дата";
        Console.Write("Введите день недели: ");
        string day = Console.ReadLine();
        Console.Write("Введите сегодняшнее число:");
        string date = Console.ReadLine();
        Console.Write("Введите текущий месяц: ");
        string month = Console.ReadLine();
        Console.WriteLine($"{day} {date} {month}");
        Console.ReadKey();
    }
}
