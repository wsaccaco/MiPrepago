using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WS_MiPrepago.Dominio;

namespace WS_MiPrepago.Persistencia
{
    public class ReservaDAO
    {
        public Reserva crear(Reserva ReservaACrear)
        {
            Reserva ReservaCreado = null;
            int createid = 0;
            string sql = "INSERT INTO Reserva(nombre,apellidos,email,celular,cantidad,fecha,proveedor_id) output INSERTED.reserva_id VALUES(@nombre, @apellido, @email, @celular, @cantidad, GETDATE(), @proveedor_id)";
            using (SqlConnection conexion = new SqlConnection(Util.CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@nombre", ReservaACrear.nombre));
                    comando.Parameters.Add(new SqlParameter("@apellido", ReservaACrear.apellido));
                    comando.Parameters.Add(new SqlParameter("@email", ReservaACrear.email));
                    comando.Parameters.Add(new SqlParameter("@celular", ReservaACrear.celular));
                    comando.Parameters.Add(new SqlParameter("@cantidad", ReservaACrear.cantidad));
                    comando.Parameters.Add(new SqlParameter("@proveedor_id", ReservaACrear.proveedor_id));
                    createid = (int) comando.ExecuteScalar();
                }
            }
            ReservaCreado = obtener(createid);
            return ReservaCreado;
        }

        public Reserva obtener(int Id)
        {
            Reserva ReservaEncontrado = null;
            string sql = "SELECT r.reserva_id,r.nombre,r.apellidos,r.email,r.celular,r.cantidad,r.proveedor_id,p.nombre proveedor FROM Reserva r "+
                            "inner join proveedor p on p.proveedor_id = r.proveedor_id WHERE Reserva_id = @id";
            using (SqlConnection conexion = new SqlConnection(Util.CadenaConexion))
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
                                reserva_id = Int32.Parse(resultado["reserva_id"].ToString()),
                                nombre = (string)resultado["nombre"],
                                apellido = (string)resultado["apellidos"],
                                email = (string)resultado["email"],
                                celular = (string)resultado["celular"],
                                cantidad = Int32.Parse(resultado["cantidad"].ToString()),
                                proveedor_id = Int32.Parse(resultado["proveedor_id"].ToString()),
                                proveedor = (string)resultado["proveedor"]

                            };
                        }
                    }
                }
            }

            return ReservaEncontrado;
        }
    }
}