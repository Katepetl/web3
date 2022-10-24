// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Vvedite koordinati pervoi tochki: x,y,z. Vvedite x");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Vvedite y");
int y=int.Parse(Console.ReadLine()!);
Console.WriteLine("Vvedite z");
int z=int.Parse(Console.ReadLine()!);
Console.WriteLine("Vvedite koordinati vtoroi tochki: x1,y1,z1. Vvedite x1");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Vvedite y1");
int y1=int.Parse(Console.ReadLine()!);
Console.WriteLine("Vvedite z1");
int z1=int.Parse(Console.ReadLine()!);
double GetSize(int x,int x1,int y, int y1, int z, int z1)
{
double distance=Math.Sqrt(Math.Pow(x1-x,2)+Math.Pow(y1-y,2)+Math.Pow(z1-z,2));
return distance;
}
double distance= GetSize(x,x1,y,y1,z,z1);
Console.WriteLine(distance);