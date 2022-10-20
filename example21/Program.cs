// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine(" Задача 21");
int xa = Coordinate("x", "A");
int ya = Coordinate("y", "A");
int za = Coordinate("z", "A");
int xb = Coordinate("x", "B");
int yb = Coordinate("y", "B");
int zb = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double xa, double xb,
                double ya, double yb,
                double za, double zb)
{
    return Math.Sqrt(Math.Pow((xb - xa), 2) +
                     Math.Pow((yb - ya), 2) +
                     Math.Pow((zb - za), 2));
}

double segmentLength = Math.Round(Decision(xa, xb, ya, yb, za, zb), 2);

Console.WriteLine($"Длина отрезка  {segmentLength}");
