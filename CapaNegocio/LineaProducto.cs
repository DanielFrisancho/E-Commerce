using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class LineaProducto
    {
        //Definir Atributos
        private int cantidad;
        private int precio;

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Precio { get => precio; set => precio = value; }

        // definir metodos
        public string OrganizarProductos()
        {
            return "metodo no implementado";
        }
    }
}
