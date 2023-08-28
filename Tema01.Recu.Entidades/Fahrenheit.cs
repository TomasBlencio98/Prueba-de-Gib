using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema01.Recu.Entidades
{
    public class Fahrenheit
    {
        private double grados;

        public double GetGrados()
        {
            return grados;
        }
        public Fahrenheit()
        {
            grados = 0;
        }
        public Fahrenheit(double grados)
        {
            this.grados = grados;
        }
    }
}
