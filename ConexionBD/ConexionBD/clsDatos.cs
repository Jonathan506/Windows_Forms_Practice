using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBD
{
    class clsDatos
    {
        internal string nombre, apellido;
        internal int id, edad;

        public string p_nombre 
        {
            set
            {
                 nombre = value;
            } 
        }

        public string p_apellido
        {
            set
            {
                apellido = value;
            }
        }

        public int p_id
        {
            set
            {
                id = value;
            }
        }
        public int p_edad
        {
            set
            {
                edad = value;
            }
        }
    }
}
