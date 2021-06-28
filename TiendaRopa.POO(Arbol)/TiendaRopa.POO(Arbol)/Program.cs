using System;
using System.Collections.Generic;
using TiendaRopa.Entidades;

namespace TiendaRopa.POO_Arbol_
{
    class Program
    {
        static void Main(string[] args)
        {
            var tiendaRopa = new Tienda
            {
                Nombre = "Eta Fashion",
                Direccion = "Av. Galo Plaza Lasso",
                NumeroEmpleados = 0,
                Empleados = new List<Empleado>
                {
                    new Empleado
                    {
                        Nombre = "Juan",
                        Apellido = "Diaz",
                        AñosLaborales = 7,
                        Edad = 27,
                        Genero = "Masculino",
                        Talla = "M"
                    },
                    new Empleado
                    {
                        Nombre = "Ana",
                        Apellido = "Molina",
                        AñosLaborales = 2,
                        Edad = 22,
                        Genero = "Femenino",
                        Talla = "M"
                    },
                    new Empleado
                    {
                        Nombre = "Erika",
                        Apellido = "Sanchez",
                        AñosLaborales = 5,
                        Edad = 28,
                        Genero = "Femenino",
                        Talla = "L"
                    }
                },
                Ropas = new List<Ropa>
                {
                    new Ropa
                    {
                        Nombre = "Camiseta",
                        Color = "Blanca",
                        Genero = "Masculino",
                        Stock = 10,
                        Talla = "M",
                        Precio = 10.50
                    },new Ropa
                    {
                        Nombre = "Pantalon",
                        Color = "Negro",
                        Genero = "Masculino",
                        Stock = 5,
                        Talla = "L",
                        Precio = 30.50
                    },new Ropa
                    {
                        Nombre = "Camisa",
                        Color = "Verde",
                        Genero = "Femenino",
                        Stock = 3,
                        Talla = "M",
                        Precio = 5.50
                    },new Ropa
                    {
                        Nombre = "Buzo",
                        Color = "Morado",
                        Genero = "Masculino",
                        Stock = 25,
                        Talla = "M",
                        Precio = 8.50
                    },new Ropa
                    {
                        Nombre = "Vestido",
                        Color = "Rojo",
                        Genero = "Femenino",
                        Stock = 50,
                        Talla = "M",
                        Precio = 45.50
                    },new Ropa
                    {
                        Nombre = "Blusa",
                        Color = "Rosa",
                        Genero = "Femenino",
                        Stock = 7,
                        Talla = "M",
                        Precio = 15.50
                    }
                }
            };
            Console.WriteLine(string.Format("┌{0}┐", new string('─', 50)));
            Console.WriteLine(string.Format("│{0} {1}│", "".PadLeft(13), tiendaRopa.Bienvenida().PadRight(36)));
            Console.WriteLine(string.Format("└{0}┘", new string('─', 50)));

            Console.WriteLine($"Número Empleados: {tiendaRopa.NumeroEmpleado()}\n");
            Console.WriteLine(tiendaRopa.Presentacion());
            Console.WriteLine("----------------------------------------------------\n");
            Console.WriteLine("Ayudanos con tus datos:");
            Console.WriteLine("Nombre:");
            string nombreCliente = Console.ReadLine();

            Console.WriteLine("Apellido:");
            string apellidoCliente = Console.ReadLine();

            Console.WriteLine("Género:");
            string generoCliente = Console.ReadLine();

            Console.WriteLine("Talla:");
            string tallaCliente = Console.ReadLine();

            Cliente nuevoCliente = new Cliente { };


            nuevoCliente.DatosCliente(nombreCliente, apellidoCliente, generoCliente, tallaCliente);


            bool masCompras = true;

            do
            {
                Console.Clear();
                Console.WriteLine($"Muy bien {nombreCliente} ayudanos con el producto que deceas comprar:\n");
                tiendaRopa.MostrarCatalogo();
                int seleccionarRopa = int.Parse(Console.ReadLine());

                Console.Clear();
                tiendaRopa.Comprar(seleccionarRopa - 1, nuevoCliente);
                Console.WriteLine("¿Deseas comprar algo mas? s/n");
                string check = Console.ReadLine();
                if (check == "n" || check == "N")
                {
                    masCompras = false;
                }

            } while (masCompras == true);

            Console.Clear();
            Console.WriteLine($"Total de compra: ${nuevoCliente.Total()}");
            Console.WriteLine($"Gracias por comprar en {tiendaRopa.Nombre}");
            Console.WriteLine("-----------------------------------\n");
            Console.Read();

            Console.Clear();
            Console.WriteLine($"Número de Nodos: {tiendaRopa.ObtenerNodos()}");
            Console.WriteLine($"Número de Hojas: {tiendaRopa.ObtenerHojas()}");
            Console.WriteLine($"Número de Niveles: {tiendaRopa.ObtenerNiveles()}");
            Console.Read();
        }
    }
}