using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstacionesModel
{
    public class EstacionServicio
    {
        private string id;
        private int capacidadMaxima;
        private string region;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int CapacidadMaxima
        {
            get
            {
                return capacidadMaxima;
            }

            set
            {
                capacidadMaxima = value;
            }
        }

        public string Region
        {
            get
            {
                return region;
            }

            set
            {
                region = value;
            }
        }
    }
}
