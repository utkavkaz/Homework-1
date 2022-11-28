// Задача необязательная FIZZ BUZZ: Напишите программу, которая выводит на экран числа от 1 до 100. 
// При этом вместо чисел, кратных трем, программа должна выводить слово Fizz, 
// а вместо чисел, кратных пяти — слово Buzz. Если число кратно пятнадцати, 
// то программа должна выводить слово FizzBuzz. Задача может показаться очевидной, 
// но нужно получить наиболее простое и красивое решение.

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

int num = new Random().Next(1, 100);
Console.WriteLine(num);

int num1 = num % 15;
int num2 = num % 5;
int num3 = num % 3;

if (num1 == 0) Console.WriteLine("FizzBuzz");
else if (num2 == 0) Console.WriteLine("Buzz");
else if (num3 == 0) Console.WriteLine("Fizz");
else Console.WriteLine(num);