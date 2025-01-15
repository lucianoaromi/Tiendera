using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class SoftwareStateDAL
    {
        private readonly string connectionString = "Data Source=LUCIANO320\\LUCIANO320;Initial Catalog=ARDUINO_BD;Integrated Security=True;Encrypt=False";

        // Método para obtener el estado del software
        public SoftwareState ObtenerEstado()
        {
            SoftwareState estado = null;

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                conn.Open();
                string query = "SELECT FechaInicio, DiasPermitidos, Activado, CodigoActivacion, FechaActivacion FROM SoftwareState";
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        estado = new SoftwareState
                        {
                            FechaInicio = Convert.ToDateTime(reader["FechaInicio"]),
                            DiasPermitidos = Convert.ToInt32(reader["DiasPermitidos"]),
                            Activado = Convert.ToBoolean(reader["Activado"]),
                            CodigoActivacion = reader["CodigoActivacion"].ToString(),
                            FechaActivacion = Convert.ToDateTime(reader["FechaActivacion"])
                        };
                    }
                }
            }
            return estado;
        }

        public void ActualizarEstado(bool activado, DateTime? fechaActivacion = null, string codigo = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Asegúrate de que la consulta esté usando el identificador único para actualizar
                    string query = "UPDATE SoftwareState SET Activado = @Activado, FechaActivacion = @FechaActivacion, CodigoActivacion = @Codigo WHERE CodigoActivacion = @Codigo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Activado", activado);
                        cmd.Parameters.AddWithValue("@FechaActivacion", fechaActivacion.HasValue ? (object)fechaActivacion.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Codigo", !string.IsNullOrEmpty(codigo) ? (object)codigo : DBNull.Value);
                        cmd.Parameters.AddWithValue("@FechaActivacion", fechaActivacion.HasValue ? (object)fechaActivacion.Value : DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error de base de datos: " + ex.Message);
            }
        }


    }
}
