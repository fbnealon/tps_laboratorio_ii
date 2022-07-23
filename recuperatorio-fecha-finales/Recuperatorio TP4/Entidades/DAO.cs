using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoConsultaOIdRepetido(object sender, EventArgs e);

    public class DAO
    {
        private static SqlConnection connection;
        private static SqlCommand command;
        private static string connectionString;

        public event DelegadoConsultaOIdRepetido ConsultaOIdRepetido;

        static DAO()
        {
            DAO.connectionString = @"Data Source=localhost;Initial Catalog=pacientes_db;Integrated Security=True";
            DAO.command = new SqlCommand();
            DAO.connection = new SqlConnection(DAO.connectionString);
            DAO.command.Connection = DAO.connection;
            DAO.command.CommandType = System.Data.CommandType.Text;
        }

        public static List<Persona> ObtenerPacientes()
        {
            List<Persona> pacientes = new List<Persona>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM pacientes";
                SqlDataReader sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    pacientes.Add(new Persona((int)sqlDataReader["id"],
                                                sqlDataReader["nombre"].ToString(),
                                                sqlDataReader["apellido"].ToString(),
                                                (int)sqlDataReader["edad"],
                                                sqlDataReader["especialidad"].ToString()));
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return pacientes;
        }

        public static List<Persona> ObtenerPacientes(int id)
        {
            List<Persona> pacientes = new List<Persona>();

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.Parameters.AddWithValue("@id", id);
                command.CommandText = "SELECT * FROM pacientes WHERE id = @id";
                SqlDataReader sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    pacientes.Add(new Persona((int)sqlDataReader["id"],
                                                sqlDataReader["nombre"].ToString(),
                                                sqlDataReader["apellido"].ToString(),
                                                (int)sqlDataReader["edad"],
                                                sqlDataReader["especialidad"].ToString()));
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return pacientes;
        }

        public static List<Persona> ObtenerPacientes(string nombre, string apellido, string especialidad)
        {
            List<Persona> pacientes = new List<Persona>();

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@especialidad", especialidad);
                command.CommandText = "SELECT * FROM pacientes WHERE nombre = @nombre AND apellido = @apellido AND especialidad = @especialidad";
                SqlDataReader sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    pacientes.Add(new Persona((int)sqlDataReader["id"],
                                                sqlDataReader["nombre"].ToString(),
                                                sqlDataReader["apellido"].ToString(),
                                                (int)sqlDataReader["edad"],
                                                sqlDataReader["especialidad"].ToString()));
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return pacientes;
        }



        public bool Agregar(Persona persona)
        {
            bool rta = false;
            try
            {
                List<Persona> PacienteYConsultaRepetidos = DAO.ObtenerPacientes(persona.Nombre, persona.Apellido, persona.EspecialidadString);
                PacienteYConsultaRepetidos.Add(persona);
                List<Persona> IdRepetido = DAO.ObtenerPacientes(persona.Id);
                IdRepetido.Add(persona);
                if (PacienteYConsultaRepetidos is not null && PacienteYConsultaRepetidos.Count > 1)
                {
                    this.ConsultaOIdRepetido.Invoke(PacienteYConsultaRepetidos, EventArgs.Empty);
                    rta = false;
                }
                else if (IdRepetido is not null && IdRepetido.Count > 1)
                {
                    this.ConsultaOIdRepetido.Invoke(IdRepetido, EventArgs.Empty);
                    rta = false;
                }
                else
                {
                    command.Parameters.Clear();
                    connection.Open();
                    command.CommandText = "INSERT INTO pacientes (id, nombre, apellido, edad, especialidad) VALUES (@id, @nombre, @apellido, @edad, @especialidad)";
                    command.Parameters.AddWithValue("@id", persona.Id);
                    command.Parameters.AddWithValue("@nombre", persona.Nombre);
                    command.Parameters.AddWithValue("@apellido", persona.Apellido);
                    command.Parameters.AddWithValue("@edad", persona.Edad);
                    command.Parameters.AddWithValue("@especialidad", persona.EspecialidadString);
                    rta = true;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
            return rta;
        }

        public static bool AgregarExistentes(List<Persona> personas)
        {
            bool rta = false;
            foreach (Persona item in personas)
            {

                try
                {
                    command.Parameters.Clear();
                    connection.Open();
                    command.CommandText = "INSERT INTO pacientes (id, nombre, apellido, edad, especialidad) VALUES (@id, @nombre, @apellido, @edad, @especialidad)";
                    command.Parameters.AddWithValue("@id", item.Id);
                    command.Parameters.AddWithValue("@nombre", item.Nombre);
                    command.Parameters.AddWithValue("@apellido", item.Apellido);
                    command.Parameters.AddWithValue("@edad", item.Edad);
                    command.Parameters.AddWithValue("@especialidad", item.EspecialidadString);
                    rta = true;
                    command.ExecuteNonQuery();

                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
            return rta;
        }

        public bool Modificar(Persona persona)
        {
            bool rta = false;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE  pacientes SET nombre = @nombre, apellido = @apellido, edad = @edad, especialidad = @especialidad WHERE id = @id";
                command.Parameters.AddWithValue("@id", persona.Id);
                command.Parameters.AddWithValue("@nombre", persona.Nombre);
                command.Parameters.AddWithValue("@apellido", persona.Apellido);
                command.Parameters.AddWithValue("@edad", persona.Edad);
                command.Parameters.AddWithValue("@especialidad", persona.Especialidad);
                rta = true;
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return rta;
        }

        public bool Eliminar(Persona persona)
        {
            bool rta = false;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM pacientes WHERE id = @id";
                command.Parameters.AddWithValue("@id", persona.Id);
                rta = true;
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return rta;
        }
    }
}
