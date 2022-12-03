// See https://aka.ms/new-console-template for more information
using System.Text;

double a, b,  x, n,m;
Console.OutputEncoding = Encoding.Unicode;
Console.Write("Введіть значення a= ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введіть значення b=");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введіть значення x= ");
x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введіть значення n=");
n = Convert.ToDouble(Console.ReadLine());
Console.Write("Введіть значення m=");
m = Convert.ToDouble(Console.ReadLine());
double z1 = (((m - 1) * Math.Sqrt(m))-((n-1)* Math.Sqrt(n)))/(Math.Sqrt(Math.Pow(x,3)*n)+n*m+Math.Pow(m,2)-m);
double z2=(Math.Sqrt(m)- Math.Sqrt(n))/m;
double y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / 2) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, 1 / 2.0) * (x - b);
Console.WriteLine($"Значення z1={z1}");
Console.WriteLine($"Значення z2={z2}");
Console.WriteLine($"Значення y={y}");