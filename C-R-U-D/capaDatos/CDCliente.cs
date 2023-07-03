using System;
using System.Data.SqlClient;    
using System.Data;
using System.Windows.Forms;
using capaEntidad;

namespace capaDatos
{
    public class CDCliente : clsCliente
    {
        
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-C9A7UDS2;Initial Catalog=CRUD;Integrated Security=True");
        public void conectar()
        {
            try
            {
                con.Open();
                MessageBox.Show("Conexión establecida");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                con.Close();
                MessageBox.Show("Error en la conexión");
            }
        }
        public void insertar(clsCliente ce)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-C9A7UDS2;Initial Catalog=CRUD;Integrated Security=True");
                con.Open();
                string Query = "INSERT INTO tb_usuario (primerNombre, segundoNombre, primerApellido, segundoApellido, correo, foto) VALUES ('" + ce.primerNombre + "', '" + ce.segundoNombre + "', '" + ce.primerApellido + "', '" + ce.segundoApellido + "', '" + ce.correo + "', '" + ce.foto + "');";

                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Datos ingresados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void editar(clsCliente ce)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-C9A7UDS2;Initial Catalog=CRUD;Integrated Security=True");
                con.Open();
                string Query = "UPDATE tb_usuario SET primerNombre = '" + ce.primerNombre + "', segundoNombre = '" + ce.segundoNombre + "', primerApellido = '" + ce.primerApellido + "', segundoApellido = '" + ce.segundoApellido + "', correo = '" + ce.correo + "', foto = '" + ce.foto + " WHERE id = " + ce.id + "";

                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Datos actualizados");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Eliminar(clsCliente ce)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-C9A7UDS2;Initial Catalog=CRUD;Integrated Security=True");
                con.Open();
                string Query = "DELETE FROM tb_usuario WHERE id = " + ce.id + ";";

                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Usuario eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataSet Listar() 
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-C9A7UDS2;Initial Catalog=CRUD;Integrated Security=True");
            con.Open();

            string Query = "select * from tb_usuario";

            SqlDataAdapter adactador;
            DataSet dataSet = new DataSet();

            adactador = new SqlDataAdapter(Query, con);
            adactador.Fill(dataSet, "tb_usuario");

            return dataSet;
        }

    }
}
