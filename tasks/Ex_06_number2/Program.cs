﻿//  6. Выяснить является ли число чётным
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0) Console.WriteLine($"Число {number} - четное число. ");
else if (number % 2 == 1) Console.WriteLine($"Число {number} - нечетное число. ");
