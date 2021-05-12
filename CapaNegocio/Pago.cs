using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Pago
    {
        //Definir atributos
        private string id;
        private DateTime fechaPago;
        private int paga;

        public string Id { get => id; set => id = value; }
        public DateTime FechaPago { get => fechaPago; set => fechaPago = value; }
        public int Paga { get => paga; set => paga = value; }

        // Definir Metodos
        public string Cobrar()
        {
            return " metodo no implementado ";
        }
    }
}
