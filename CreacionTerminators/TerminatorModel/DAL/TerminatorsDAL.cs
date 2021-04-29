using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerminatorModel.DTO;

namespace TerminatorModel.DAL
{
    public class TerminatorsDAL
    {
        private static List<Terminator> terminators = new List<Terminator>();

        public void Save(Terminator t)
        {
            terminators.Add(t);
        }


        public List<Terminator> GetAll()
        {
            return terminators;
        }


        public List<Terminator> FindByModelAndAnio(Tipo tipo, int anio)
        {
            //List<Terminator> aux = new List<Terminator>();
            //foreach (Terminator t in terminators)
            //{
            //    if (t.Tipo == tipo && t.AnioDestino == anio)
            //        aux.Add(t);
            //}
            //return aux;

            return terminators.FindAll(t => t.Tipo == tipo && t.AnioDestino == anio);
        }


        public Terminator FindByNroSerie(string nroSerie)
        {
            //Terminator aux = null;
            //foreach (Terminator t in terminators)
            //{
            //    aux = t;
            //    break;
            //}
            //return aux;

            return terminators.Find(t => t.NroSerie == nroSerie);
        }


        public void Delete(Terminator t)
        {
            terminators.Remove(t);
        }
    }
}
