
// НЕ РАБОЧИЙ

/*
using System;

public class Answer
{
    //static bool IsPalindrome(int number){
    static bool IsPalindrome(int number){
      // Введите свое решение ниже
      bool result = true;
      int size = 5;
      string length = number.ToString(); 
      //if ((number < 10000) || (number => 100000)){
      if (length.Length != size){
        Console.WriteLine("число не пятизначное");
        return false;
      }
      else{
        for (int i = 0; i < length.Length; i++){
            if (number[i] != number[number.Length -1 -i]){
                
            }
            result = false;
            break;       
        } 
        return result;
      }
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}
*/