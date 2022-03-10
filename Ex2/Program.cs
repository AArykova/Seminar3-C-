// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A(xa,ya,za)   B(xb,yb,zb)
// Distance = Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za))
Random random = new Random();

var xa = random.Next(1000);
int xb = random.Next(1000);
int ya = random.Next(1000);
int yb = random.Next(1000);
int za = random.Next(1000);
int zb = random.Next(1000);

Console.WriteLine("A("+ xa + ";" + ya + ";" + za + ")");
Console.WriteLine("B("+ xb + ";" + yb + ";" + zb + ")");

double Distance = Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za));
Console.WriteLine("Расстояние между А и В - " + Distance);
