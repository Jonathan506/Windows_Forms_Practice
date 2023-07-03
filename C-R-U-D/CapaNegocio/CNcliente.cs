using System;
using System.Windows.Forms;
using capaEntidad;
using capaDatos;
using System.Data.SqlClient;
using System.Data;

namespace CapaNegocio
{
    public class CNcliente
    {
        public bool ValidarDatos(clsCliente cliente)
        {
            bool resultado = true;

            if (cliente.primerNombre == string.Empty)
            {
                resultado = false;
                MessageBox.Show("El primer nombre es obligatorio");
            }

            else if (cliente.segundoNombre == string.Empty)
            {
                resultado = false;
                MessageBox.Show("El segundo nombre obligatorio");
            }

            else if (cliente.primerApellido == string.Empty)
            {
                resultado = false;
                MessageBox.Show("El primer apellido es obligatorio");
            }

            else if (cliente.segundoApellido == string.Empty)
            {
                resultado = false;
                MessageBox.Show("El segundo apellido es obligatorio");
            }

            else if (cliente.correo == string.Empty)
            {
                resultado = false;
                MessageBox.Show("El correo electronico es obligatorio");
            }

            else if (cliente.foto == null)
            {
                resultado = false;
                MessageBox.Show("La Foto es obligatoria");
            }

            return resultado;
        }
        CDCliente con = new CDCliente();
        public void conexion() 
        {
            con.conectar();
        
        }

        public void crearUsuario(clsCliente clsCliente) 
        {
            con.insertar(clsCliente);
        }

        public void editarUsuario(clsCliente clsCliente)
        {
            con.editar(clsCliente);
        }

        public void EliminarUsuario(clsCliente clsCliente)
        {
            con.Eliminar(clsCliente);
        }

        public DataSet obtenerDatos() 
        {
            return con.Listar();
        }

    }

}

