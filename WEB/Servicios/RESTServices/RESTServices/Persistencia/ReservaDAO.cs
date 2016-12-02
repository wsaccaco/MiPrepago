using RESTServices.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RESTServices.Persistencia
{
    public class ReservaDAO
    {
        public Reserva crear(Reserva ReservaACrear)
        {
            Reserva ReservaCreado = null;
            string sql = "INSERT INTO Ventas VALUES(null, @estado, @cantidad, GETDATE(), @codigoReserva, @modeloId)";
            using (SqlConnection conexion = new SqlConnection(utilConexion.CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@estado", ReservaACrear.estado));
                    comando.Parameters.Add(new SqlParameter("@cantidad", ReservaACrear.cantidad));
                    //comando.Parameters.Add(new SqlParameter("@fecha", ReservaACrear.fecha));
                    comando.Parameters.Add(new SqlParameter("@codigoReserva", ReservaACrear.codigoReserva));
                    comando.Parameters.Add(new SqlParameter("@modeloId", ReservaACrear.modeloId));
                    comando.ExecuteNonQuery();
                }
            }
            ReservaCreado = obtener(ReservaACrear.id);
            return ReservaCreado;
        }

        public Reserva obtener(int Id)
        {
            Reserva ReservaEncontrado = null;
            string sql = "SELECT * FROM ventas WHERE id = @id";
            using (SqlConnection conexion = new SqlConnection(utilConexion.CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", Id));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            ReservaEncontrado = new Reserva()
                            {
                                id = Int32.Parse(resultado["id"].ToString()),
                                estado = (string)resultado["estado"],
                                cantidad = Int32.Parse(resultado["cantidad"].ToString()),
                                fecha = (DateTime)resultado["fecha"],
                                codigoReserva = (string)resultado["codigo_reserva"],
                                modeloId = Int32.Parse(resultado["modelo_id"].ToString()),
                            };
                        }
                    }
                }
            }

            return ReservaEncontrado;
        }

    }
}