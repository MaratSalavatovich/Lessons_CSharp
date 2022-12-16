// Задача 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) 
//и выводит на экран десятичное представление числа, записанного в СС по основанию 15
//N: 3 [9, 4, 12] => 2097

//Ввод количества чисел в массиве
// Создание массива
// Заполнение массива  числами от 0-14
//Вывод/печать массива
// конвертор из 15ричной СС в 10ричную


public class HomeWork3
{
    public static void Task29()
    {

        Console.Write("Введите число чисел в массиве : ");
        int numberA = Convert.ToInt32(Console.ReadLine());
        int[] ar = MyLibrary.CreatArray(numberA);
        MyLibrary.Fill(ar);
        //Console.WriteLine(MyLibrary.Print(ar));
        double Expo = MyLibrary.Exponen(ar);
        Console.WriteLine($"{MyLibrary.Print(ar)} в 15 СС =>  в 10 CC {Expo}");

    }
}
