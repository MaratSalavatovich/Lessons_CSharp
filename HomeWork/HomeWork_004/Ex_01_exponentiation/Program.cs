﻿//## Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.Clear();
Console.Write("Введите число A: ");
int numberA = Convert.Int32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.Int32(Console.ReadLine());

int Metod(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}


int exponentiation = Metod(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} = " + exponentiation);