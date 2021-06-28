using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaRopa.Entidades
{
    public class Empleado : Persona
    {
        public int AñosLaborales { get; set; }
        public int Edad { get; set; }
    }
}