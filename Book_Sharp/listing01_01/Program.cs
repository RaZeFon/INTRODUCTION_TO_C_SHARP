/*
Напишите программу, в которой пользователь вводит сначала имя, а затем фамилию.
программа выводит сообщение с информацией об имени и фамилии пользователя. Предложите 
версию программы в которой ввод и вывод текста осуществляется с помощью диалоговых
окон. А также предложите консольную версию программы.
*/
 
using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;
 
class UserName{
    static void Main(){
        string name = Interaction.InputBox("Как ваше имя?", "Введите имя");
        string surname = Interaction.InputBox("Какая у вас фамилия?", "Введите фамилию");
        string text_name = "Приятно познакомить " + name + " " + surname;
        MessageBox.Show(text_name, "Приветствие");
    }
}
 
//====================================================================================
 
using System;
using static System.Console;
 
class UserName{
    static void Main(){
 
        Clear();
 
        Title = "Давайте познакомимся";
        Write("Как ваше имя? ");
        string name = ReadLine();
        Write("Какая у вас фамилия? ");
        string surname = ReadLine();
        WriteLine($"Приятно познакомится {name} {surname}");
        ReadKey();
    }
}
