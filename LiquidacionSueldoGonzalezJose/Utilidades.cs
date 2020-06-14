using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquidacionSueldoGonzalezJose
{
    class Utilidades
    {
        public bool validaRut(string rut)
        {
            int[] constantesValidacion = { 3, 2, 7, 6, 5, 4, 3, 2 };
            double suma = 0;

            switch (rut.Length)
            {
                case 9: rut = "0" + rut; break;
                case 8: rut = "00" + rut; break;
                case 7: rut = "000" + rut; break;
                case 6: rut = "0000" + rut; break;

            }

            for (int j = 0; j < constantesValidacion.Length; j++)
            {
                suma = suma + (Int16.Parse(rut[j].ToString()) * constantesValidacion[j]);

            }

            double division = suma / 11;
            int divisionentero = (int)division;
            double resto = division - divisionentero;
            double resta = 11 - (11 * resto);
            var digito = Math.Round(resta);

            string digitorut = rut[9].ToString();

            if (digitorut == "k")
            {
                digitorut = "9";
            }
            else if (digitorut == "0")

            {
                digitorut = "11";
            }

            if (digito.ToString() == digitorut)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
