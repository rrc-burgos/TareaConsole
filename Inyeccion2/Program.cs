using System;
using Ninject;
using Ninject.Modules;
using Dependencia;
using Ventas;
using System.Reflection;
using ProyectoInyeccion;

namespace Inyeccion2
{
    class Program  
    {
        static void Main(string[] args)
        {
            StandardKernel _Kernel = new StandardKernel();
            _Kernel.Load(Assembly.GetExecutingAssembly());
            IMercado __objetoMercado = _Kernel.Get<IMercado>();  
            Fruta _objFruta = new Fruta(_frutaUnidad);    
            _objFruta.IngresoFruta();
            Console.ReadLine();
        }
    }
}

