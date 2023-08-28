using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema01.Recu.Entidades
{
    public class Celsius
    {
        private double grados;

        public double GetGrados()
        {
            return grados;
        }
        public Celsius()
        {
            grados = 0;
        }
        public Celsius(double grados)
        {
            this.grados = grados;
        }

        public static implicit operator double(Celsius v)
        {
            return v.GetGrados();
        }

        public static implicit operator Celsius(double v)
        {
            return new Celsius(v);
        }

        public static explicit operator Celsius(Fahrenheit v)
        {
            return new Celsius((v.GetGrados() - 32) * 5 / 9);
        }

        public static explicit operator Celsius(Kelvin v)
        {
            return new Celsius(v.GetGrados()*5);
        }
    }
}
