/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

пример: 645 -> 5
        78 -> третьей цифры нет
        32679 -> 6
*/

using System;
using static System.Console;
Clear();

Write("Введите число: ");
string number = ReadLine();
int length = 3;
if (number.Length < length){
    WriteLine("Третьей цифры нет");
}
ThirdNumber(number);

void ThirdNumber(string str_num){
    for (int i = 0; i < str_num.Length; i++){
        if (i == 2){
            WriteLine($"{str_num} -> {str_num[i]}");
        }
    }
}
