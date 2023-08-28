using Tema01.Recu.Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        var celsius = new Celsius(15);
        var fahrenheit = new Fahrenheit(15);
        var kelvin=new Kelvin(15);

        double celsiusDouble = celsius;
        double celDouble = 15;

        Celsius celsius1 = celDouble;


        Console.WriteLine(celsius = (Celsius) fahrenheit);
        celsius = (Celsius) kelvin;
        Console.WriteLine(celsius=(Celsius)kelvin);










        Console.ReadLine();

    }
}