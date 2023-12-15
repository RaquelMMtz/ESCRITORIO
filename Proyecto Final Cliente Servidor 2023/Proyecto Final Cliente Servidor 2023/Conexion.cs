using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Cliente_Servidor_2023
{
    internal class Conexion
    {
        private SqlConnection conexion;
        private string cadenaConexion;

        public Conexion(string servidor, string baseDatos, string usuario, string password)
        {
            cadenaConexion = $"Data Source=DESKTOP-7NQK83I\\SQLEXPRESS;Initial Catalog=AreaServices;User ID={usuario};Password={password}";
            conexion = new SqlConnection(cadenaConexion);
        }

        public void Abrir()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexión establecida");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }
        }

        public void Cerrar()
        {
            conexion.Close();
            Console.WriteLine("Conexión cerrada");
        }


        // Ejemplo de método para realizar una consulta
        public void EjecutarConsulta(string consulta)
        {
            try
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    // Procesar los datos obtenidos
                    string resultado = reader.GetString(0);
                    Console.WriteLine(resultado);
                }

                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
            }
        }

    }
}
