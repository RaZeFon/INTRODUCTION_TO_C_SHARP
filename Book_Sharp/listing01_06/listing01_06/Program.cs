/*
Напишите программу, в которой пользователь вводит имя и год рождения, а программа отображает 
сообщение, содержащие имя пользователя и его возраст. Предложите консольную версию программы, а также
версию программы, в который ввод и вывод данных выполняется с помощью диалоговых окон.
 */


using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class UserNameAge
{
    static void Main()
    {
        int year = 2023;
        string name = Interaction.InputBox("Введите своё имя: ", "Имя");
        string str_year = Interaction.InputBox("Введите год рождения: ", "Год");
        int age = year - Int32.Parse(str_year);
        MessageBox.Show($"Вас зовут {name} и вам {age} лет.");
    }
}



using System;
using static System.Console;

class UserNameAge
{
    static void Main()
    {
        Clear();
        Title = "Имя и возраст";
        int year = 2023;
        Write("Введите имя: ");
        string name = ReadLine();
        Write("Введите год рождения: ");
        int birth_year = int.Parse(ReadLine());
        WriteLine($"Вы {name} и вам {year - birth_year} лет");
    }
}


