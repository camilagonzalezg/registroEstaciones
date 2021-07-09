using RegistroEstacionesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstacionesModel.DAL
{
    public class EstacionServicioDAL
    {
        //Lista estatica de estaciones de servicio
        private static List<EstacionServicio> estacionesServicio = new List<EstacionServicio>();

        //metodo agregar
        public void Add(EstacionServicio e)
        {
            estacionesServicio.Add(e);
        }

        //ver en grilla
        public List<EstacionServicio> GetAll()
        {
            return estacionesServicio;
        }

        ////filtrar por id
        //public List<EstacionServicio> GetAll(int id)
        //{
        //    return estacionesServicio.FindAll(e => e.Id == id);
        //}

        //eliminar
        public void Remove(string id)
        {
            //para buscar, se busca primero
            EstacionServicio est = estacionesServicio.Find(e => e.Id == id);

            //se elimina
            estacionesServicio.Remove(est);
        }

    }
}
