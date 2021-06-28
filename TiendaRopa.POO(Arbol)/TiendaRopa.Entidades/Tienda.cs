using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaRopa.Entidades
{
    public class Tienda
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int NumeroEmpleados { get; set; }
        public List<Ropa> Ropas { get; set; } = new List<Ropa>();
        public List<Empleado> Empleados { get; set; } = new List<Empleado>();

        public int ObtenerNodos()
        {    
            int totalNodos = 0;
            foreach (Ropa ropaA in Ropas)
            {
                totalNodos += 1;
            }
            foreach (Empleado empleadoA in Empleados)
            {
                totalNodos += 1;
            }
            return totalNodos + 1;
        }

        public int ObtenerHojas()
        {
            int totalHojas = 0;
            foreach (Ropa ropaA in Ropas)
            {
                totalHojas += 1;
            }
            foreach (Empleado empleadoA in Empleados)
            {
                totalHojas += 1;
            }
            return totalHojas;
        }

        public int ObtenerNiveles()
        {
            var nivel = 0;
            foreach (Ropa ropaA in Ropas)
            {
                nivel += 1;
            }
            nivel = (Ropas.Count + 1) - nivel;          
            return ++nivel;
        }

        public string Bienvenida()
        {         
            return $"Bienvenido a {Nombre}";
        }

        public string Presentacion()
        {
            Random numeroAleatorio = new Random();
            int empleadoAleatorio = numeroAleatorio.Next(0, Empleados.Count);
            return $"Me presento, mi nombre es {Empleados[empleadoAleatorio].Nombre} y tengo {Empleados[empleadoAleatorio].Edad} años.";
        }

        public int NumeroEmpleado()
        {
            NumeroEmpleados = Empleados.Count;
            return NumeroEmpleados;
        }

        public void MostrarCatalogo()
        {
            int contador = 1;
            foreach (Ropa ropaActual in Ropas)
            {
                if (ropaActual.Stock >= 1)
                {
                    Console.WriteLine($"[{contador}] - {ropaActual.Nombre} {ropaActual.Color} {ropaActual.Talla} {ropaActual.Stock}: ${ropaActual.Precio}");
                    contador++;
                }
            }
        }

        public void Comprar(int indice, Cliente cliente)
        {
            Ropas[indice].Stock -= 1;
            cliente.Productos.Add
            (
                new Producto
                {
                    Nombre = Ropas[indice].Nombre,
                    Precio = Ropas[indice].Precio
                }
            );

            foreach (Producto productoA in cliente.Productos)
            {
                Console.WriteLine($"Producto comprado: {productoA.Nombre}: ${productoA.Precio}");
            }
        }       
    }
}