using System;
using System.Collections.Generic; 
using Consola;
namespace tareaConsola 
{
    class Program
    {
         static void Main(string[] arg) 
        {
            Console.WriteLine("LA HISTORIA DE NARUTO UZUMAKI");
            var protagonista = new Protagonista 
            {
                Nombre = "Naruto",
                Apellido = "Uzumaki",
                Genero = "Masculino",
                CantidadDeChakra = "1000",
                CantidadDeArmas = "7",
                PoderOculto = "20000" ,
                ColorDeCabello = "Rubio" ,
                Altura = "1.82" ,
                Kurama = "El zorro De las Nueve Colas" ,
                ColordeRopa =  "Naranja"  
            };
            Console.WriteLine(protagonista.SaludoNombre());
            Console.WriteLine(protagonista.DefinicionGenero());
            Console.WriteLine(protagonista.CanChakra());
            Console.WriteLine(protagonista.CaArmas());
            Console.WriteLine(protagonista.PodOculto());
            Console.WriteLine(protagonista.ColorCa());
            Console.WriteLine(protagonista.Alturat());
            Console.WriteLine(protagonista.Kuramat());
            Console.WriteLine(protagonista.ColorRop());
            

            var aldea = new Aldea
            {
                NombreAldea = "Aldea de la hoja",
                CantidadDeTerreno = "40.000 hectareas",
                CantidadDeHabitantes = "70.000 Habitantes",
                NombreDelHokague = "Tsunade",
                CantidadDeNinjas = "50.000 ninjas",
                CantidadDeNegocios = "35.000",
                EjercitoDeDefensa = "80.000 ninjas",
                SeñoresFeudales = "3 Señores Feudales",
                FechaDeFundacion = "24 de febrero del 1745",
                DiasFestivos = "28 de julio , Dia de La marmota Fiesta del Hokague"
            };
            Console.WriteLine(aldea.Naldea());
            Console.WriteLine(aldea.CantidadTerre());
            Console.WriteLine(aldea.CantidadH());
            Console.WriteLine(aldea.NombreH());
            Console.WriteLine(aldea.CanNinjas());
            Console.WriteLine(aldea.CanNego());
            Console.WriteLine(aldea.EjerciDefensa());
            Console.WriteLine(aldea.SenoresFeu());
            Console.WriteLine(aldea.FechaFun());
            Console.WriteLine(aldea.DiasF());

        }
       
    }
}



















