using System;
using Dependencia;
namespace Ventas 
{
    public class Tienda : IMercado
    {
        public string InsertarFruta()
        {
            string fruta = "Se ingresa fruta con ninject";
            Console.WriteLine(fruta);
            return fruta; 
        }
    }
    

    
    

    
}