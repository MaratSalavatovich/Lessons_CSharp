﻿// Задача 2: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("start"); // Старт приложения -чисто для удоства
int a = -2; // В условии задачи число нам задают изначально под программу
if (a % 2 == 0) // Проверка условия деления числа на цело или нет (четное/нечетное)
{
    Console.WriteLine("Even"); //Если число делится на два без остатка - вывести честное число
}
else
{
    Console.WriteLine("Odd"); // если число делится с остатком - вывести нечетное число
}

Console.WriteLine("end");