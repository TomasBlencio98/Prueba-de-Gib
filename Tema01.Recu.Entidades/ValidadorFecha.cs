using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema01.Recu.Entidades
{
    public static class ValidadorFecha
    {
        public static bool Validar(int dia, int mes, int anio)
        {
            if ((dia >= 1 && dia <= 31) && (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12) && (anio > 0))
            {
                return true;
            }
            if ((dia >= 1 && dia <= 30) && ((mes == 4 || mes == 6 || mes == 9 || mes == 11)) && (anio > 0))
            {
                return true;
            }
            if ((mes == 2 && dia <= 28) || (mes == 2 && dia == 29 && EsBisiesto(anio)))
            {
                return true;
            }

            return false;
        }

        private static bool EsBisiesto(int anio)
        {
            return anio % 4 == 0 && (anio % 100 != 0 || anio % 400 == 0);
        }
    }
}
