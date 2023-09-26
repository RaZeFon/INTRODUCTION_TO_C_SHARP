/*
Напишите программу, в которой пользователь вводит имя и возраст. Программа отображает сообщение 
об имени и возрасте пользователя. Предложите консольную версию программы и версию, в которой
данные вводятся и выводятся с помощью диалоговых окон.
*/


using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class NameAge{
    static void Main(){
        string name = Interaction.InputBox("Как вас зовут? ", "Введите имя");
        string age = Interaction.InputBox("Сколько вам лет? ", "Введите возраст");
        MessageBox.Show("Ты " + name + " и тебе " + age + " лет");
    }
}

//===============================================================

using System;

class NameAge
{
    static void Main()
    {
        Console.Clear();
        Console.Title  = "Ведите данные о себе: ";
        Console.Write("Введите имя: ");
        string name = Console.ReadLine();
        Console.Write("Введите ваш возраст: ");
        string age = Console.ReadLine();
        Console.WriteLine($"Ты {name} и тебе {age} лет");
        Console.ReadKey();
    }
}