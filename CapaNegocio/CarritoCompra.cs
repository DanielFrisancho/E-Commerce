using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CarritoCompra
    {
        // Definir atributos
        private DateTime fechaCreacion;

        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }

        //Definir metodos
        public string AlmacenarProductos()
        {
            return "metodo no implementado";
        }
        public string VerificarStock()
        {
            return "metodo no implementado";
        }
    }
}
