using Tema01.Recu.Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        PiramideCuadrada piramide = new PiramideCuadrada(10, 5);
        Console.WriteLine("Altura"+piramide.GetAltura());
        Console.WriteLine("LadoBase"+piramide.GetLadoBase());
        Console.WriteLine("Arista"+piramide.GetArista());
        Console.WriteLine("Volumen"+piramide.GetVolumen());
        Console.WriteLine("Area" + piramide.GetArea());


        Console.ReadLine();
    }
}