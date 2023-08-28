using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema01.Recu.Entidades
{
    public class Kelvin
    {
        private double grados;

        public double GetGrados()
        {
            return grados;
        }
        public Kelvin()
        {
            grados = 0;
        }
        public Kelvin(double grados)
        {
            this.grados = grados;
        }
    }
}
