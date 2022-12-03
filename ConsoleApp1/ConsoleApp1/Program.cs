// See https://aka.ms/new-console-template for more information

using System.Text;

class Program
{
    static void Main(string[] args)
    {
      Console.OutputEncoding = Encoding.Unicode;
double a, b, c, d,x;
Console.Write("Введіть значення a= ");
a=Convert.ToDouble( Console.ReadLine());
Console.Write("Введіть значення b=");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введіть значення c= ");
c=Convert.ToDouble( Console.ReadLine());
Console.Write("Введіть значення d=");
d = Convert.ToDouble(Console.ReadLine());
        x = first_p(a, b, c, d);
        Console.WriteLine($"Значення x={x}");
        second_p(a, b, c, d);
        third_p(a, b, x);
        forth_p(a, b, c);
    }
    public static double first_p(double a, double b, double c, double d)
{
        double x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - (Math.Pow(a, 2) / Math.Pow(b, 2));
        return x;
}
    public static void second_p(double a, double b, double c, double d)
    {
        double y = ((5 * (a + b) * (c - d)) / ((1 / 2.0) * c)) + Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a));
        Console.WriteLine($"Значення y={y}");
    }
    public static void third_p(double a, double b, double x)
    {
        double z =((Math.Pow((Math.Pow(x,2)-2*x),3)-(4*(Math.Pow(x,4)+1)))*(1-b))/(5*a+3*b) ;
        Console.WriteLine($"Значення z={z}");
    }
    public static void forth_p(double a, double b, double c)
    {
        double r = ((1/2.0+((3/4.0)*b)-7/5.0)/(3*c+1))+(1/(a-c));
        Console.WriteLine($"Значення r={r}");
    }

}



