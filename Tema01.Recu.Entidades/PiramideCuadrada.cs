using System.Xml.Linq;

namespace Tema01.Recu.Entidades
{
    public class PiramideCuadrada
    {
        private double ladoBase;
        private double altura;
        private double arista;

        public PiramideCuadrada(double ladoBase, double altura)
        {
            if (ladoBase<0 || altura<0)
            {
                throw new ArgumentException("Datos mal ingresados");
            }
            this.ladoBase = ladoBase;
            this.altura = altura;
            this.arista = CalcularArista();
        }
        public double CalcularArista()
        {
            return Math.Sqrt(Math.Pow(altura, 2) + (Math.Pow(ladoBase, 2)) / 2);
        }

        public double GetArista()
        {
            return arista;
        }
        public double GetLadoBase()
        {
            return ladoBase;
        }
        public double GetAltura()
        {
            return altura;
        }

        public double GetArea()
        {
            return ladoBase*(ladoBase+Math.Sqrt(4*Math.Pow(altura, 2)+Math.Pow(ladoBase,2)));
        }
        

        public double GetVolumen()
        {
            return (Math.Pow(ladoBase, 2) * altura) / 3;
        }
    }
}