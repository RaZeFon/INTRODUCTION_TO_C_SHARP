/*
Напишите программу, в которой по году рождения определяеться возрвст пользователя.
Используйте консольный ввод и ввод данных.
*/


using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class CurrentAge
{
    static void Main()
    {
        int year = 2023;
        string birth_year = Interaction.InputBox("Введите год своего рождения", "Год рождения");
        int age = year - Int32.Parse(birth_year);
        MessageBox.Show($"Вам {age} лет.");
    }
}

//==============================================================================

using System;
using static System.Console;

class CurrentAge
{
    static void Main()
    {
        Clear();
        Title = "Ваш возраст";
        Write("Введите год рождения: ");
        int year = 2023;
        int brith_year = int.Parse(ReadLine());
        WriteLine($"Вам {2023 - brith_year} лет.");
    }
}
