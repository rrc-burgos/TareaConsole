using System;
namespace Consola
{
    public class Aldea 
    {
        public string NombreAldea { get; set; }
        public string CantidadDeTerreno { get; set; }
        public string CantidadDeHabitantes { get; set; }
        public string NombreDelHokague { get; set; }
        public string CantidadDeNinjas { get; set; }
        public string CantidadDeNegocios { get; set; }
        public string EjercitoDeDefensa { get; set; }
        public string SeñoresFeudales { get; set; }
        public string FechaDeFundacion { get; set; }
        public string DiasFestivos { get; set; } 



        public string Naldea()
        {
            return $"El nombre de la aldea es {this.NombreAldea}, Es una aldea muy bonita y grande ";
           
        }
        public string CantidadTerre()
        {
            return $"La cantidad de Terreno es   {this.CantidadDeTerreno}, Es un espacio muy grande rodeado de bosques";
            
        }
        public string CantidadH()
        {
            return $" La cantidad de Habitantes es {this.CantidadDeHabitantes},  soy un ninja de la Hoja ";
            
        }
        public string NombreH()
        {
            return $" El hokague es el lider de la aldea se llama {this.NombreDelHokague},  Es quien proteje la aldea y se encarga de administrar nuestras misiones ninja";
            
        }

        public string CanNinjas()
        {
            return $" La cantidad de ninjas es  {this.CantidadDeNinjas},  que estan para protejer y cumplir las misiones de la aldea";
            
        }


        public string CanNego()
        {
            return $" Los negcios que hay son {this.CantidadDeNegocios},  Incluyendo mi lugar favorito para comer ramen Ichiraku";
            
        }


        public string EjerciDefensa()
        {
           return $" El ejercito esta conformado por {this.EjercitoDeDefensa},  Para llevar la seguridad y protejer nuestras fronteras de inavsiones";
            
        }

        public string SenoresFeu()
        {
            return $" Los Señores Feudales Son  {this.SeñoresFeudales},  Para llevar la seguridad y protejer nuestras fronteras de inavsiones";
            
        }

        public string FechaFun()
        {
            return $" La Aldea de la Hoja Se Fundo en   {this.FechaDeFundacion},  Como un lugar para la formacion de los mejores ninjas";
            
        }

        public string DiasF()
        {
             return $" En nuestros dias festivos celebramos  {this.DiasFestivos},  En estas fechas realizamos festivales de todo tipo";
            
        }
    }
}


