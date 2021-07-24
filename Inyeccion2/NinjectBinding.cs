using Dependencia;
using Ventas; 
using System;
    namespace ProyectoInyeccion 
    {
        public class NinjectBinding: Ninject.Modules.NinjectModule
        {
        public override void Load()
        {
            Bind<IMercado>.To<Tienda>();
        }

    }
    }

