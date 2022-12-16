//Задача 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) и выводит на экран десятичное представление числа, записанного в СС по основанию 15

public static class MyLibrary

{


    //Создание массива
    public static int[] CreatArray(int count)
    {
        return new int[count];
    }


    //Заполнение массива числами в диапазоне [0;14)
    public static void Fill(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Shared.Next(0, 15);
        }
    }


    //вывод массива
    public static string Print(int[] array)
    {
        return string.Join(' ', array);
    }


    //возведение в степень  
    // a^b = a*a*a*a*a*a....*a - b раз 
    public static int Pow(int a, int b)
    {
        int result = 1;
        for (int i = 0; i < b; i++)
        {
            result = result * a;
        }
        return result;
    }

    //написать конвертор из 15 в 10
    //Массив [5, 3, 14, 9]
    //       3   2   1   0  - показатели степени
    // 9*15^0 + 14*15^1 + 3*15^2 + 5*15^3
    public static int Exponen(int[] value)
    {
        int result = 0;
        int count = value.Length;
        for (int i = 0; i < count; i++)
        {
            result += value[i] * Pow(15, count - 1 - i);
        }
        return result;
    }

}