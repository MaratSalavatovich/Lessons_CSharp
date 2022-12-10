// ## Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//Формула вычисления расстояния между двумя точками A(xa, ya) и B(xb, yb) на плоскости: AB = √(xb - xa)2 + (yb - ya)2
//A (0,0); B (1,1), -> ~1.4

//A (2,4); B (0,7) -> ~3.6
int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");

int Coordinate(string Coord, string Name)
{
    Console.Write($"Введите координату {Coord} точки {Name}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double distance(double x1, double x2,
                double y1, double y2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                     Math.Pow((y2 - y1), 2));
}

double segment = Math.Round(distance(x1, x2, y1, y2), 2);

Console.WriteLine($"Длина отрезка  {segment}");