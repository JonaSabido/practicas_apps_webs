using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practicaResistencia.Infraestructure
{
    public class ResistenciaRepository
    {
        public string Calcular(string banda1, string banda2, string banda3, string banda4)
        {
            float resultado;
            string tolerancia;

            banda1 = banda1.ToLower();
            banda2 = banda2.ToLower();
            banda3 = banda3.ToLower();
            banda4 = banda4.ToLower();

            switch (banda1)
            {
                case "negro":
                    resultado = 0;
                    break;
                case "cafe":
                    resultado = 10;
                    break;
                case "rojo":
                    resultado = 20;
                    break;
                case "naranja":
                    resultado = 30;
                    break;
                case "amarillo":
                    resultado = 40;
                    break;
                case "verde":
                    resultado = 50;
                    break;
                case "azul":
                    resultado = 60;
                    break;
                case "violeta":
                    resultado = 70;
                    break;
                case "gris":
                    resultado = 80;
                    break;
                case "blanco":
                    resultado = 90;
                    break;
                default:
                    return "El color de la banda 1 no es un color válido";
            }

            switch (banda2)
            {
                case "negro":
                    resultado = resultado + 0;
                    break;
                case "cafe":
                    resultado = resultado + 1;
                    break;
                case "rojo":
                    resultado = resultado + 2;
                    break;
                case "naranja":
                    resultado = resultado + 3;
                    break;
                case "amarillo":
                    resultado = resultado + 4;
                    break;
                case "verde":
                    resultado = resultado + 5;
                    break;
                case "azul":
                    resultado = resultado + 6;
                    break;
                case "violeta":
                    resultado = resultado + 7;
                    break;
                case "gris":
                    resultado = resultado + 8;
                    break;
                case "blanco":
                    resultado = resultado + 9;
                    break;
                default:
                    return "El color de la banda 2 no es un color válido";
            }

            switch (banda3)
            {
                case "negro":
                    resultado = resultado * 1;
                    break;
                case "cafe":
                    resultado = resultado * 10;
                    break;
                case "rojo":
                    resultado = resultado * 100;
                    break;
                case "naranja":
                    resultado = resultado * 1000;
                    break;
                case "amarillo":
                    resultado = resultado * 10000;
                    break;
                case "verde":
                    resultado = resultado * 100000;
                    break;
                case "azul":
                    resultado = resultado * 1000000;
                    break;
                case "dorado":
                    resultado = resultado / 10;
                    break;
                case "plata":
                    resultado = resultado / 100;
                    break;
                default:
                    return "El color de la banda 3 no es un color válido";
            }

            switch (banda4)
            {
                case "dorado":
                    tolerancia = "5%";
                    break;
                case "plata":
                    tolerancia = "10%";
                    break;
                default:
                    return "El color de la banda 4 no es un color válido";
            }

            return "La resistencia es: " + resultado + "Ω y su tolerancia es de: " + tolerancia;
        }
    }
}
