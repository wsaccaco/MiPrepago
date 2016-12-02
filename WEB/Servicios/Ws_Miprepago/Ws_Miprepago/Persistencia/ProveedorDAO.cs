using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WS_MiPrepago.Dominio;

namespace WS_MiPrepago.Persistencia
{
    public class ProveedorDAO
    {
        public List<Proveedor> Listar()
        {
            List<Proveedor> ProveedoresEncontrados = new List<Proveedor>();
            Proveedor ProveedorEncontrado = null;
            string sql = "SELECT * FROM proveedor";
            using (SqlConnection conexion = new SqlConnection(Util.CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            ProveedorEncontrado = new Proveedor()
                            {
                                proveedor_id = Int32.Parse(resultado["proveedor_id"].ToString()),
                                ruta = (string)resultado["ruta_servicio"],
                                tipo = (string)resultado["tipo_servicio"],
                                nombre = (string)resultado["nombre"]
                            };
                            ProveedoresEncontrados.Add(ProveedorEncontrado);
                        }
                    }
                }
            }
            return ProveedoresEncontrados;
        }
    }
}