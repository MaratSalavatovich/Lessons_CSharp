﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1 ///

int number = 321;
if ((number) > 99 && (number) < 1000) //Если выполняется данное условие - тогда проивзодим вычисление
    Console.WriteLine(number = (number / 10) % 10);
else
    Console.WriteLine("Число не трехзначное");