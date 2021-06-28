using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaRopa.Entidades
{
    public class Cliente : Persona
    {
        public List<Producto> Productos { get; set; } = new List<Producto>();


        public void DatosCliente(string nombreCliente, string apellidoCliente, string generoCliente, string tallaCliente)
        {
            Nombre = nombreCliente;
            Apellido = apellidoCliente;
            Genero = generoCliente;
            Talla = tallaCliente;
        }

        public Double Total()
        {
            Double total = 0;
            foreach (Producto productoA in Productos)
            {
                total += productoA.Precio;
            }
            return total;
        }
    }   
}
 