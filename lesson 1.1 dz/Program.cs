
/*ЗАДАНИЕ 1 --------------------------------------------------------------------------------------------------------

Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.

Пример использования:
На входе:


firstNumber: '5'
secondNumber: '6'
На выходе:


второе число больше





using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
      
      if (firstNumber > secondNumber) {
        Console.WriteLine("первое число больше");
      }  else {
        if (secondNumber > firstNumber) {
          Console.WriteLine("второе число больше");
        } else {
          Console.WriteLine("числа равны");
        }
      }
    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 5;
            secondNumber = 6;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}

*/

/* --------------------------------------------------------------------------------

using System;

public class Answer {
    
  static int FindMax(int a, int b, int c)
    {
      // Введите свое решение ниже

    if ((a > b) & (a > c)) {
      return a;
    } else
    {
      if (b > c)
      {
        return b;
      }
      else
      {
        return c;
      }
    }


    }

  // Не удаляйте и не меняйте метод Main! 
  static public void Main(string[] args) {
        int a, b, c;

        if (args.Length >= 3) {
           a = int.Parse(args[0]);
           b = int.Parse(args[1]);
           c = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           a = 5;
           b = 6;
           c = 7;
        }

        // Не удаляйте строки ниже
        int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}

*/


  