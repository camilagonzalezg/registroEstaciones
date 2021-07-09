using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstacionesModel
{
    public partial class PuntoCarga
    {
        private string id;
        private int tipo;
        private int capacidadMaxima;
        private DateTime fechaVencimiento;

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

        public int Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
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

        public DateTime FechaVencimiento
        {
            get
            {
                return fechaVencimiento;
            }

            set
            {
                fechaVencimiento = value;
            }
        }
    }
}
