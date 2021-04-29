using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerminatorModel.DAL;
using TerminatorModel.DTO;

namespace CreacionTerminators.Partials
{
    public partial class Program 
    {
        static TerminatorsDAL dal = new TerminatorsDAL();

        static void IngresarTerminator()
        {
            string nroSerie, objetivo;
            int prioridad, anioDestino;
            Tipo tipo = Tipo.T1;

            do
            {
                Console.WriteLine("Ingrese Numero de Serie");
                nroSerie = Console.ReadLine().Trim();
                if (nroSerie.Length != 7)
                {

                    Console.WriteLine("El nro de serie debe ser de largo 7");
                    nroSerie = string.Empty;
                }
                else if(dal.FindByNroSerie(nroSerie) != null)
                {
                    Console.WriteLine("El Terminator ya Existe");
                    nroSerie = string.Empty;
                }
            } while (nroSerie == string.Empty);

            tipo = GetTipo();

            do
            {
                Console.WriteLine("Ingrese Objetivo");
                objetivo = Console.ReadLine().Trim();

            } while (objetivo == string.Empty);

            if (objetivo.ToLower() == "Sarah Connor")
            {
                prioridad = 999;
            }
            else
            {
                //PEDIR LA PRIORIDAD    
                do
                {
                    Console.WriteLine("Ingrese Prioridad");
                    string prioriText = Console.ReadLine().Trim();
                    //contiene un try catch
                    if (!Int32.TryParse(prioriText, out prioridad))
                    {
                        prioridad = -1;
                        Console.WriteLine("Prioridad Incorrecta");
                    }

                } while (prioridad < 0 || prioridad > 999);
            }

            anioDestino = GetAnioDestino();

            Terminator t = new Terminator()
            {
                NroSerie = nroSerie, Objetivo= objetivo, AnioDestino = anioDestino,
                Tipo = tipo,
                Prioridad = prioridad
            };

            dal.Save(t);
        }
        

        static void MostrarTerminator()
        {
            List<Terminator> terminators = dal.GetAll();
            //foreach (Terminator t in terminators)
            //{
            //    Console.WriteLine(t);
            //}
            terminators.ForEach(Console.WriteLine);
        }


        static void BuscarTerminators()
        {
            Tipo tipo = GetTipo();
            int anio = GetAnioDestino();

            List<Terminator> terminators = dal.FindByModelAndAnio(tipo, anio);
            terminators.ForEach(Console.WriteLine);
        }


        static Boolean Menu()
        {
            bool continuar = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ");
            Console.WriteLine("Bienvenido a Skynet");
            Console.WriteLine("1. Ingresar Terminator");
            Console.WriteLine("2. Mostrar Terminator");
            Console.WriteLine("3. Buscar Terminator");
            Console.WriteLine("0. Salir");

            string opcion = Console.ReadLine().Trim();
            switch (opcion)
            {
                case "1": IngresarTerminator();
                    break;
                case "2": MostrarTerminator();
                    break;
                case "3": BuscarTerminators();
                    break;
                case "0": continuar = false;
                    break;
                default:
                    Console.WriteLine("Use Bien el teclado Porfavor");
                    break;
            }
            return continuar;
        }


        static void Main(string[] args)
        {
            while (Menu()) ;
        }
    }
}
