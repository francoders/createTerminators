using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerminatorModel.DTO;

namespace CreacionTerminators.Partials
{
    public partial class Program
    {
        public static int GetAnioDestino()
        {
            //Leer anio Destino
            int anioDestino = -1;

            do
            {
                Console.WriteLine("Ingrese año de destino");
                if (!Int32.TryParse(Console.ReadLine().Trim(), out anioDestino))
                {
                    Console.WriteLine("El año de destino debe ser numerico");
                    anioDestino = -1;
                }
                else if (anioDestino < 1984 || anioDestino > 3000)
                {
                    Console.WriteLine("El año esta fuera de los rangos permitidos");
                    anioDestino = -1;
                }
            } while (anioDestino < 1984 || anioDestino > 3000);
            return anioDestino;
        }



        public static Tipo GetTipo()
        {
            String resp; 
            Tipo tipo = Tipo.T1;

            do
            {
                Console.WriteLine("Seleccione Tipo");
                Console.WriteLine("1. T-1, 2. T-800, 3. T-1000, 4. T-3000");
                resp = Console.ReadLine().Trim();
                switch (resp)
                {
                    case "1":
                        tipo = Tipo.T1;
                        break;
                    case "2":
                        tipo = Tipo.T800;
                        break;
                    case "3":
                        tipo = Tipo.T1000;
                        break;
                    case "4":
                        tipo = Tipo.T3000;
                        break;
                    default:
                        Console.WriteLine("Tipo Incorrecto, reingrese");
                        resp = string.Empty;
                        break;
                }
            } while (resp == String.Empty);
            return tipo;
        }
    }
}
