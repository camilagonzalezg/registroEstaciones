using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstacionesModel.DAL
{
    public class PuntoCargaDAL
    {

        //Lista estatica de estaciones de servicio
        private static List<PuntoCarga> puntosCarga = new List<PuntoCarga>();

        //metodo agregar
        public void Add(PuntoCarga p)
        {
            puntosCarga.Add(p);
        }

        //ver en grilla
        public List<PuntoCarga> GetAll()
        {
            return puntosCarga;
        }

        //filtrar por tipo
        public List<PuntoCarga> GetAll(int tipo)
        {
            return puntosCarga.FindAll(p => p.Tipo == tipo);
        }

        //eliminar
        public void Remove(string id)
        {
            //para buscar, se busca primero
            PuntoCarga punt = puntosCarga.Find(p => p.Id == id);

            //se elimina
            puntosCarga.Remove(punt);
        }

    }
}
