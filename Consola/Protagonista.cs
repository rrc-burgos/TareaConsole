using System;

namespace Consola 
{
    public class Protagonista 
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CantidadDeChakra { get; set; } 
        public string Genero { get; set; }
        public string CantidadDeArmas { get; set; }
        public string PoderOculto { get; set; }
        public string ColorDeCabello { get; set; }
        public string Altura { get; set; }
        public string Kurama { get; set; }
        public string ColordeRopa { get; set; } 


        public string SaludoNombre()
        {
            return $"Hola, me llamo  {this.Nombre} {this.Apellido}, Y Los quiero invitar a conocer mi aldea ";
            
        }
       
        public string DefinicionGenero()
        {
           return  $" Mi genero es  {this.Genero},  con el genero me identifico en mi credencial ninja   "; 
            
        }

        public string CanChakra() 
        {
            return $" Mi cantidad de Chakra  {this.CantidadDeChakra},  El chakra es muy importante para las tecnicas";
            

        }

        public string CaArmas()
        {
            return $" Mi cantidad de Armas es   {this.CantidadDeArmas},  Mis armas mas importantes para el combate son mis shuriken";
            
        }

        public string PodOculto()
        {
            return $" Tengo un poder oculto de   {this.PoderOculto},  Este poder proviene de algo muy poderoso en mi interior";
            
        }

        public string ColorCa()
        {
            return $" Mi color de cabello es    {this.ColorDeCabello},  Me gusta cuidar mi cabello para verme siempre bien";
            
        }

        public string Alturat()
        {
            return $" Mi altura es    {this.Altura},  Seguramente voy a crecer mucho mas y muy fuerte";
            
        }

        public string Kuramat()
        {
           return $" Poseo a Kurama  {this.Kurama},  Kurama el zorro de las 9 colas vive en mi interior y potencia mi chakra";
            
        }

        public string ColorRop()
        {
            return  $" Mi color de mi ropa es     {this.ColordeRopa},  Mi color de ropa  me gusta como combina con mi chaqueta";
           
        }

    }
}




















