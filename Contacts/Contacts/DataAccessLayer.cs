using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    public class DataAccessLayer
    {
        //Acceder a la base de datos y se encarga de las consultas 

        private SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Contacts_Windows_Forms;Data Source=LAPTOP-C9A7UDS2\\SQLEXPRESS");

        public void InsertContact(Contact contact) 
        {
            try
            {
                conexion.Open();
                string query = @"
                                 insert into contact(FirstName, LastName, Phone, Address)
                                 Values (@firstName, @LastName, @Phone, @Address)";

                SqlParameter firstName = new SqlParameter(); //Forma extensa
                firstName.ParameterName = "@FirstName";
                firstName.Value = contact.FirstName;
                firstName.DbType = System.Data.DbType.String;

                //forma reducida
                SqlParameter lastName = new SqlParameter("@LastName", contact.LastaName);
                SqlParameter phone = new SqlParameter("@Phone", contact.Phone);
                SqlParameter address = new SqlParameter("@Address", contact.Address);

                SqlCommand comand = new SqlCommand(query, conexion);
                comand.Parameters.Add(firstName);
                comand.Parameters.Add(lastName);
                comand.Parameters.Add(phone);
                comand.Parameters.Add(address);

                comand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw;
            }
            finally 
            {
                conexion.Close();
            }
        }
    }
}
