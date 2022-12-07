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

        public static Usuario Usuario
        {
            get { return usuario;  }
            set { usuario = value;  }
        }
    }
}
