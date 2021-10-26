using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practicaAlcohol.Infraestructure
{
    public class AlcoholRepository
    {
        public double Calculo(string bebida, double cantidad, double peso)
        {
            bebida = bebida.ToLower();
            double ml;
            double grados_alcohol;

            switch (bebida)
            {
                case "cerveza":
                    ml = 330 * cantidad;
                    grados_alcohol = 5;
                    break;
                case "vino":
                case "cava":
                    ml = 100 * cantidad;
                    grados_alcohol = 12;
                    break;
                case "vermu":
                    ml = 70 * cantidad;
                    grados_alcohol = 17;
                    break;
                case "licor":
                    ml = 45 * cantidad;
                    grados_alcohol = 23;
                    break;
                case "brandy":
                    ml = 45 * cantidad;
                    grados_alcohol = 38;
                    break;
                case "combinado":
                    ml = 50 * cantidad;
                    grados_alcohol = 38;
                    break;
                default:
                    ml = 0;
                    grados_alcohol = 0;
                    break;
            }

            double resultado = Calculo2(ml, grados_alcohol, peso);
            return resultado;
        }

        public double Calculo2(double ml, double grados_alcohol, double peso)
        {
            double alcohol_consumido;
            double masa;
            double resultado;
            double v;
            double litros_sangre;

            alcohol_consumido = (grados_alcohol / 100) * ml;
            v = .15 * alcohol_consumido;
            masa = .789 * v;
            litros_sangre = peso * .08;
            resultado = masa / litros_sangre;

            return resultado;
        }
    }
}
