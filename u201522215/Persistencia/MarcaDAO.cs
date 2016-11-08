using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using u201522215.Dominio;

namespace u201522215.Persistencia
{
    public class MarcaDAO
    {
        private string cadenaConexion = "Data source=(local); Initial catalog=BD_MiPrepago; Integrated security=SSPI;";

        public Marca crear(Marca marcaACrear)
        {
            Marca marcaCreado = null;
            string sql = "INSERT INTO marca VALUES(@marca_id, @nombre)";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using(SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@marca_id", marcaACrear.marca_id));
                    comando.Parameters.Add(new SqlParameter("@nombre", marcaACrear.nombre));
                    comando.ExecuteNonQuery();
                }
            }
            marcaCreado = obtener(marcaACrear.marca_id);
            return marcaCreado;
        }

        public Marca obtener(int Id)
        {
            Marca marcaEncontrado = null;
            string sql = "SELECT * FROM marca WHERE marca_id = @id";
            using(SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", Id));
                    using(SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            marcaEncontrado = new Marca()
                            {
                                marca_id = Int32.Parse( resultado["marca_id"].ToString()),
                                nombre = (string) resultado["nombre"]
                            };
                        }
                    }
                }
            }

            return marcaEncontrado;
        }

        public Marca modificar(Marca marcaAModificar)
        {
            Marca marcaModificada = null;
            string sql = "";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@marca_id", marcaAModificar.marca_id));
                    comando.Parameters.Add(new SqlParameter("@nombre", marcaAModificar.nombre));
                    comando.ExecuteNonQuery();
                }
            }
            marcaModificada = obtener(marcaAModificar.marca_id);
            return marcaModificada;
        }

        public List<Marca> Listar()
        {
            List<Marca> marcasEncontradas = new List<Marca>();
            Marca marcaEncontrada = null;
            string sql = "SELECT * FROM marca";
            using(SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using(SqlCommand comando = new SqlCommand(sql, conexion)){
                    using(SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read()){
                            marcaEncontrada = new Marca()
                            {
                                marca_id = Int32.Parse(resultado["marca_id"].ToString()),
                                nombre = (string)resultado["nombre"]
                            };
                            marcasEncontradas.Add(marcaEncontrada);
                        }
                    }
                }
            }
            return marcasEncontradas;
        }
    }
}