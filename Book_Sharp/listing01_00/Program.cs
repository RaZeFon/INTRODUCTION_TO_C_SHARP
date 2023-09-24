
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



