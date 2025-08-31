using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ejercicio_CRUD.Personas;


namespace Ejercicio_CRUD
{
    public class Personas
    {
        private string connectionString ="Data Source=LAPTOP-RHFQ1TRV\\SQLEXPRESS;Initial Catalog=CRUDWindowsForm;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

        public bool correcto()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    conexion.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public List<Persona> Get()
        {
            List<Persona> personas = new List<Persona>();

            string query = "select * from Personas";

            using (SqlConnection connection  = new SqlConnection(connectionString)) 
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Persona unaPersona = new Persona();
                        unaPersona.Id = reader.GetInt32(0);
                        unaPersona.Nombre = reader.GetString(1);
                        unaPersona.Apellido = reader.GetString(2);
                        unaPersona.Mail = reader.GetString(3);
                        personas.Add(unaPersona);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch(Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos" + ex.Message);
                }
            }


            return personas;
        }

        public Persona ObtenerID(int? Id)
        {
           
            string query = "select ID, nombre, apellido, mail from Personas" + " where ID=@Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", Id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                 
                    Persona unaPersona = new Persona();
                    unaPersona.Id = reader.GetInt32(0);
                    unaPersona.Nombre = reader.GetString(1);
                    unaPersona.Apellido = reader.GetString(2);
                    unaPersona.Mail = reader.GetString(3);
                    
                    reader.Close();
                    connection.Close();
                    return unaPersona;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos" + ex.Message);
                }
            }
        }

        public void Agregar(string nombre, string apellido, string mail)
        {
            string query = "insert into Personas(nombre, apellido, mail) values" + "(@nombre, @apellido, @mail)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@mail", mail);


                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos" + ex.Message);
                }
            }
        }

        public void Editar(string nombre, string apellido, string mail, int id)
        {
            string query = "update Personas set Nombre=@nombre, Apellido=@apellido, Mail=@mail" + " where ID=@id ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@mail", mail);
                command.Parameters.AddWithValue("@id", id);


                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos" + ex.Message);
                }
            }
        }

        public void Eliminar(int id)
        {
            string query = "delete from Personas" + " where ID=@id ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);


                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos" + ex.Message);
                }
            }
        }
    }

    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public string Mail { get; set; }
    }


}
