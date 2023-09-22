/*
Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 2D пространстве.

пример: A(3, 6); B(2, 1) -> 5.09                ^y
        A(7, -5); B(1, -1) -> 7.21              |   a(x1,y1)
                                                y1  \
//длина отрезка расстояние между точками        |    \   
d = (корень)(x1-x2)**2+(y1-y2)**2               y2    \b(x2,y2)
                                                |
                                            -------x1--x2---->
                                                |           x
*/


// моё
using System;
using static System.Console;
Clear();

Write("Введите координаты A x1: ");
int Ax1 = int.Parse(ReadLine());
Write("Введите координаты A y1: ");
int Ay1 = int.Parse(ReadLine());
Write("Введите координаты B x2: ");
int Bx2 = int.Parse(ReadLine());
Write("Введите координаты B y2: ");
int By2 = int.Parse(ReadLine());
WriteLine(SegmentLength(Ax1, Ay1, Bx2, By2));

double SegmentLength(int x1, int y1, int x2, int y2){
    double sumX = Math.Pow((x1 - x2), 2);
    double sumY = Math.Pow((y1 - y2), 2);
    double result = Math.Sqrt(sumX + sumY);
    return result;
}


// учитель
using System;
using static System.Console;
Clear();

Write("Введите x1: ");
int x1 = int.Parse(ReadLine());
Write("Введите y1: ");
int y1 = int.Parse(ReadLine());
Write("Введите x2: ");
int x2 = int.Parse(ReadLine());
Write("Введите y2: ");
int y2 = int.Parse(ReadLine());

double d = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
// извлечение корня Math.Sqrt()
// возведение в степень Math.Pow(значение, степень)
WriteLine($"Длина отрезка = {d}");
WriteLine($"Длина отрезка = {d:f2}");
// чтобы сократить число в выводе есть оператор форматирования
// :f<число> <- до которого округляем






