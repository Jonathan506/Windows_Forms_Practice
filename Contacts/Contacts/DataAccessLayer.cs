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
                SqlParameter lastName = new SqlParameter("@LastName", contact.LastName);
                SqlParameter phone = new SqlParameter("@Phone", contact.Phone);
                SqlParameter address = new SqlParameter("@Address", contact.Address);

                SqlCommand comand = new SqlCommand(query, conexion);
                comand.Parameters.Add(firstName);
                comand.Parameters.Add(lastName);
                comand.Parameters.Add(phone);
                comand.Parameters.Add(address);

                comand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                conexion.Close();
            }
        }
        public void UpdateContact(Contact contact) 
        {
            try
            {
                conexion.Open();
                string query = @"UPDATE contact
                                SET FirstName = @FirstName,
                                LastName = @LastName,
                                Phone = @Phone,
                                Address = @Address
                                WHERE Id = @Id";

                SqlParameter id = new SqlParameter("@Id", contact.Id);
                SqlParameter firstName = new SqlParameter("@FirstName", contact.FirstName);
                SqlParameter lastName = new SqlParameter("@LastName", contact.LastName);
                SqlParameter phone = new SqlParameter("@Phone", contact.Phone);
                SqlParameter address = new SqlParameter("@Address", contact.Address);


                SqlCommand comand = new SqlCommand(query, conexion);
                comand.Parameters.Add(id);
                comand.Parameters.Add(firstName);
                comand.Parameters.Add(lastName);
                comand.Parameters.Add(phone);
                comand.Parameters.Add(address);

                comand.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Contact> GetContacts() 
        {
            List<Contact> contacts = new List<Contact>();
            try
            {
                conexion.Open();
                string query = @" SELECT Id, FirstName, LastName, Phone, Address
                                 FROM contact";

                SqlCommand comand = new SqlCommand(query, conexion);
                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    contacts.Add(new Contact
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Address = reader["Address"].ToString()
                    }
                    ); ;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
            return contacts;

        }

    }
}
