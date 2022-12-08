// ## Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6, 7 - выходной.
// НО дня с индексом 0 или 12 не существует.
//6 -> да
//7 -> да
//1 -> нет

Console.Clear();
Console.Write("Дорогой пользователь, введите день недели: ");

int dayNum = int.Parse(Console.ReadLine());

if (dayNum == 1 || dayNum == 2 || dayNum == 3 || dayNum == 4 || dayNum == 5)
    Console.WriteLine("\n Сегодня не выходной \n");

if (dayNum == 6 || dayNum == 7)
    Console.WriteLine("\n Ура! Сегодня выходной день \n");
else if (dayNum < 1 || dayNum > 7)

    Console.WriteLine("\n К сожалению, это не день недели \n");