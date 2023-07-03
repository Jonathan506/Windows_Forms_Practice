using System;
using System.Data.SqlClient;
using System.Data;

namespace capaEntidad
{
    public class clsCliente
    {
        public int id { get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string correo{ get; set; }
        public string foto { get; set; }

    }
}
