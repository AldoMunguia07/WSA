using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSA.Clases
{
    class VariablesGlobales
    {
        private static Usuario usuario;
        private static Conductor conductor;
        private static Cliente cliente;
        private static Producto producto;
        private static Barco barco;


        public static Usuario Usuario
        {
            get { return usuario;  }
            set { usuario = value;  }
        }

        public static Conductor Conductor
        {
            get { return conductor; }
            set { conductor = value; }
        }

        public static Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public static Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public static Barco Barco
        {
            get { return barco; }
            set { barco = value; }
        }
    }
}
