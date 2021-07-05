using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstacionesModel.DTO
{
    public class EstacionServicio
    {
        private int id;
        private int capacidadMaxima;
        private string region;

        public int Id
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
