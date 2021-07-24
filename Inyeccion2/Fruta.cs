using System;
using Dependencia;
using Ninject;
namespace ProyectoInyeccion 
{
    public class Fruta
    {
        IMercado frutaUnidad;

        public Fruta(IMercado objetoFruta)
        {
            frutaUnidad = objetoFruta;
        }

        public void IngresoFruta()
        {
            frutaUnidad.InsertarFruta(); 
        }

    } 
}
