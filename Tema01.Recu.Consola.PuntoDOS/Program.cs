using Tema01.Recu.Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(ValidadorFecha.Validar(29, 2, 2020));
        Console.WriteLine(ValidadorFecha.Validar(29, 2, 2028));

        Console.ReadLine();
    }
}