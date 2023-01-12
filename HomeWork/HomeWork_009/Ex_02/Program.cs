// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int Number(int M, int N)
{


    if (M == N) return M;
    else return M + Number(M + 1, N);


}
Console.WriteLine(Number(1, 15));