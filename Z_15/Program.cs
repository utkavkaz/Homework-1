﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 1 || a > 7) Console.WriteLine("Вы ввели некорректное число");
else
{
    if (a == 6 || a == 7)
    {
        Console.WriteLine("Является выходным днем");
    }
    else
    {
        Console.WriteLine("Не является выходным днем");
    }
}

// Console.WriteLine("Введите число от 1 до 7");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a < 1 || a > 7) Console.WriteLine("Вы ввели некорректное число");
// else if (a == 6 || a == 7) Console.WriteLine("Является выходным днем");
// else Console.WriteLine("Не является выходным днем");