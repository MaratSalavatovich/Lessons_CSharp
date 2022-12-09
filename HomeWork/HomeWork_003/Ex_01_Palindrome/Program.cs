//## Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
//14212 -> нет
//12821 -> да
//abcde
//23432 -> да

Console.Clear();
Console.Write("Дорогой пользователь, введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99999 || number < 10000)
{
    Console.WriteLine("\n Введено не пятизначное число \n");
}
else
{
    int a = number / 10000;
    int e = number % 10;
    int b = (number / 1000) % 10;
    int d = (number / 10) % 10;
    if (a == e && b == d)
    {
        Console.Write(number);
        Console.Write(" - Палиндром");
    }
    else
    {
        Console.Write(number);
        Console.Write(" - Не Палиндром");
    }
}