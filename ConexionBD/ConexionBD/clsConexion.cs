using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //BIblioteca que nos ayuda para establecer32 la conexión
using System.Data;
using System.Windows.Forms;


namespace ConexionBD 
{
    class clsConexion : clsDatos
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-C9A7UDS2;Initial Catalog=Resources;Integrated Security=True");
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
            }
        }

        public void insertar() 
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-C9A7UDS2;Initial Catalog=Resources;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                con.Open();

                cmd.CommandText = ("insertar");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@firstName", SqlDbType.VarChar,25);
                cmd.Parameters.Add("@lastName", SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@age", SqlDbType.Int);

                cmd.Parameters["@firstName"].Value = nombre;
                cmd.Parameters["@lastName"].Value = apellido;
                cmd.Parameters["@age"].Value = edad;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Los datos fueron ingresados correctamente");
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void actualizar()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-C9A7UDS2;Initial Catalog=Resources;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                con.Open();

                cmd.CommandText = ("actualizar");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@firstName", SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@lastName", SqlDbType.VarChar, 25);
                cmd.Parameters.Add("@age", SqlDbType.Int);

                cmd.Parameters["@id"].Value = id;
                cmd.Parameters["@firstName"].Value = nombre;
                cmd.Parameters["@lastName"].Value = apellido;
                cmd.Parameters["@age"].Value = edad;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Los datos fueron actualizados correctamente");
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        public void buscar(DataGridView dg) 
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-C9A7UDS2;Initial Catalog=Resources;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da;
                DataTable tb = new DataTable();

                cmd.Connection = con;
                con.Open();

                cmd.CommandText = ("buscar");
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.Add("@id",SqlDbType.Int);

                cmd.Parameters["@id"].Value = id;

                da = new SqlDataAdapter(cmd);
                da.Fill(tb);

                dg.DataSource = tb;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void eliminar(DataGridView dg)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-C9A7UDS2;Initial Catalog=Resources;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da;
                DataTable tb = new DataTable();

                cmd.Connection = con;
                con.Open();

                cmd.CommandText = ("Eliminar");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int);

                cmd.Parameters["@id"].Value = id;

                da = new SqlDataAdapter(cmd);
                da.Fill(tb);

                dg.DataSource = tb;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void visualizar(DataGridView dg)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-C9A7UDS2;Initial Catalog=Resources;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da;
                DataTable tb = new DataTable();

                cmd.Connection = con;
                con.Open();

                cmd.CommandText = ("select * from Employee");

                da = new SqlDataAdapter(cmd);
                da.Fill(tb);

                dg.DataSource = tb;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
