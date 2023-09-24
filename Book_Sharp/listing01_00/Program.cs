class MyProgram{
    // описание класса
}

//===========================================================================

// static означает что для вызова метода не нужно создавать обьект
static void Main(){
    // код программы
}

// public означает что метод является от крытом и доступен за пределами класса

//======================================================================

// шаблон для создания простой программы
class имя_класса{
    static void Main(){
        // код программы
    }
}

//=====================================================================

class HelloWorld{
    // главный метод программы
    static void Main(){
        // отображение сообщения в консольном окне
        System.Console.WriteLine("Изучаем язык C#");
    }
}

//============================================================

class HelloWorld
{
    // главный метод программы
    static void Main()
    {
        // отображение сообщения в консольном окне
        System.Console.WriteLine("Изучаем язык C#");
        System.Console.ReadLine();
    }
}

//==============================================================

// использование пространства имен System
using System;
// главный класс программы
class HelloWorld{
    // главный метод программы 
    static void Main(){
        // отображение сообщения в консольном окне
        Console.WriteLine("Изучаем язык C#");
        Console.ReadKey();
    }
}

//===============================================================

// использование пространства имен
using System.Windows.Forms;
// класс с главным методом программы
class DialogDemo{
    // главный метод программы
    static void Main(){
        // отображение диалогового окна
        MessageBox.Show("Продолжаем изучать C#");
    }
}

//====================================================================

using System.Windows.Forms;
class AnotherDialogDemo{
    static void Main(){
        // отображение диалогового окна
        MessageBox.Show("Всем привет!", //сообщение
            "Окно с названием", // название окна
            MessageBoxButtons.OK, // кнопки (одна Ok)
            MessageBoxIcon.Information // пиктограмма
            );
    }
}

//======================================================================

// используем ресурсы Visual Basic:
using Microsoft.VisualBasic;
using System.Windows.Forms;
class InputDialogDemo{
    static void Main(){
        // текстовая переменая
        string name;
        // отображение окна с полем водда
        name = Interaction.InputBox(
            "Как вас зовут? ", // текст над полем ввода
            "Давайте познакомимся... " // название окна
        );
        // ещё одна текстовая переменая
        string txt = "Очень приятно, " + name + "!";
        // окно с сообшением
        MessageBox.Show(txt, "Знакомство состоялось");
    }
}


using System;
class InputConsoleDemo
{
    static void Main()
    {
        // текстовая переменая
        string name;
        // заголовок консольного окна
        Console.Title = "Давайте позенакомимся...";
        // сообщениике в консоле 
        Console.Write("Как вас зовут? ");
        // считывание текста
        name = Console.ReadLine();
        // ещё одна текстовая переменая
        string txt = "Очень приятно, " + name + "!";
        // заголовок текстового окна
        Console.Title = "Знакомство состаялось";
        // сообщение в консоле
        Console.WriteLine(txt);
    }
}

//====================================================

using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class EnteringInteger
{
    static void Main()
    {
        // текстовые переменые
        string res, txt;
        // целочисленые переменые
        int year = 2023, age, born;
        // отображение окна в поле вода
        res = Interaction.InputBox("В каком году вы роделись?", "Год рождения");
        // предбрвзование текста в число
        born = Int32.Parse(res);
        // вычисление возраста
        age = year - born;
        txt = "Тогда вам " + age + " лет";
        // окно с сообщением
        MessageBox.Show(txt, " Возраст");
    } 
}








