using Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsListados
    {
        /// <summary>
        /// Static function that creates an object`s list from clsPersona from the database
        /// </summary>
        /// <returns></returns>
        public static List<clsPersona> listadoCompletoPersonasDal()
        {
            List<clsPersona> lista = new List<clsPersona>();
            clsPersona persona;

            clsMyConnection connection = new clsMyConnection();
            SqlConnection connect = new SqlConnection();

            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;

            try
            {
                connect = connection.getConnection();
                miComando.CommandText = "SELECT *  FROM personas";
                miComando.Connection = connect;
                miLector = miComando.ExecuteReader();


                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        persona = new clsPersona();
                        persona.Id = (int)miLector["ID"];
                        persona.Nombre = (string)miLector["Nombre"];
                        persona.Apellidos = (string)miLector["Apellidos"];
                        persona.Foto = (string)miLector["Foto"];
                        //Si sospechamos que el campo puede ser Null en la BBDD
                        if (miLector["FechaNacimiento"] != System.DBNull.Value)
                        { 
                            persona.FechaNacimiento = (DateTime)miLector["FechaNacimiento"]; 
                        }
                        persona.Direccion = (string)miLector["Direccion"];
                        persona.Telefono = (string)miLector["Telefono"];
                        lista.Add(persona);
                    }
                }
                miLector.Close();
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                connection.closeConnection(ref connect);
            }

            return lista;
        }

        public static clsPersona GetPersonaId(int id)
        {
            clsPersona persona = new clsPersona();

            clsMyConnection connection = new clsMyConnection();
            SqlConnection connect = new SqlConnection();

            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;

            try
            {
                connect = connection.getConnection();
                miComando.Parameters.AddWithValue("@Id", id);
                miComando.CommandText = "SELECT *  FROM personas WHERE Id = @Id";
                miComando.Connection = connect;
                miLector = miComando.ExecuteReader();

                while (miLector.Read())
                {
                    if (miLector.HasRows)
                    {
                        persona = new clsPersona();
                        persona.Id = (int)miLector["ID"];
                        persona.Nombre = (string)miLector["Nombre"];
                        persona.Apellidos = (string)miLector["Apellidos"];
                        persona.Foto = (string)miLector["Foto"];
                        if (miLector["FechaNacimiento"] != System.DBNull.Value)
                        {
                            persona.FechaNacimiento = (DateTime)miLector["FechaNacimiento"];
                        }
                        persona.Direccion = (string)miLector["Direccion"];
                        persona.Telefono = (string)miLector["Telefono"];
                    }
                }               
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                connection.closeConnection(ref connect);
            }

            return persona;
        }
    }
}
