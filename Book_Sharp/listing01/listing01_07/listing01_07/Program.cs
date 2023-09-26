/*
Напишите программу, в которой по возрасту определяется год рождения. Возраст пользователь 
вводит в окно с полем, а вычислинный год рождения отображается в другом диалоговом окне.
Предложите вариант программы, в которой используется консольный ввод и вывод данных.
*/


using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class UserDate
{
    static void Main()
    {
        int year = 2023;
        string str_age = Interaction.InputBox("Введите свой возраст", "Возраст");
        int age = Int32.Parse(str_age);
        int birth_year = year - age;
        MessageBox.Show($"Вы роделись в {birth_year} году", "Год рождения");
    }
}


using System;
using static System.Console;

class UserData
{
    static void Main()
    {
        Clear();
        Title = "Год рождения";
        Write("Введите ваш возраст: ");
        int yaer = 2023;
        int age = int.Parse(ReadLine());
        WriteLine($"Вы раделись {yaer - age} году");
    }
}


