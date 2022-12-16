// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82-> 10
//9012-> 12

public class Ex_02_Sum
{
    public static void Task27()
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(metod.Summa(number));
    }
}
public static class metod
{
    public static int Summa(int summ)
    {
        int r = 0;
        while (summ != 0)
        {
            r += summ % 10;
            //value = value / 10;
            summ /= 10;
        }
        return r;
    }

}
