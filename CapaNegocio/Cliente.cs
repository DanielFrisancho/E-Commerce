using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Cliente
    {
        // Definir atributos
        private string id;
        private string direccion;
        private string telefono;
        private string email;

        public string Id { get => id; set => id = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }

        // definir metodos
        public string Comprar()
        {
            return "metodo no implementado";
        }
        public string Pagar()
        {
            return "metodo no implementado";
        }
        public string RecepcionarProducto()
        {
            return "metodo no implementado";
        }
        public string Canjear()
        {
            return "metodo no implementado";
        }
    }
}
