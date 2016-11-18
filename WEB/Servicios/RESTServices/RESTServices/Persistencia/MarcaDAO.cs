using RESTServices.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RESTServices.Persistencia
{
    public class MarcaDAO
    {
       
        public Marca crear(Marca MarcaACrear)
        {
            Marca MarcaCreado = null;
            string sql = "INSERT INTO marca VALUES(@id, @nombre)";
            using (SqlConnection conexion = new SqlConnection(utilConexion.CadenaConexion))
            {
                conexion.Open();
                using(SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", MarcaACrear.Id));
                    comando.Parameters.Add(new SqlParameter("@nombre", MarcaACrear.nombre));
                    comando.ExecuteNonQuery();
                }
            }
            MarcaCreado = obtener(MarcaACrear.Id);
            return MarcaCreado;
        }

        public Marca obtener(int Id)
        {
            Marca MarcaEncontrado = null;
            string sql = "SELECT * FROM marca WHERE id = @id";
            using(SqlConnection conexion = new SqlConnection(utilConexion.CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", Id));
                    using(SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            MarcaEncontrado = new Marca()
                            {
                                Id = Int32.Parse( resultado["id"].ToString()),
                                nombre = (string) resultado["nombre"]
                            };
                        }
                    }
                }
            }

            return MarcaEncontrado;
        }

        public Marca modificar(Marca MarcaAModificar)
        {
            Marca MarcaModificada = null;
            string sql = "update marca set nombre=@nombre where id=@id";
            using (SqlConnection conexion = new SqlConnection(utilConexion.CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", MarcaAModificar.Id));
                    comando.Parameters.Add(new SqlParameter("@nombre", MarcaAModificar.nombre));
                    comando.ExecuteNonQuery();
                }
            }
            MarcaModificada = obtener(MarcaAModificar.Id);
            return MarcaModificada;
        }

        public void eliminar(int Id)
        {
            string sql = "delete from marca where @id = id";
            using (SqlConnection conexion = new SqlConnection(utilConexion.CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", Id));
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Marca> Listar()
        {
            List<Marca> MarcasEncontradas = new List<Marca>();
            Marca MarcaEncontrada = null;
            string sql = "select * from marca";
            using(SqlConnection conexion = new SqlConnection(utilConexion.CadenaConexion))
            {
                conexion.Open();
                using(SqlCommand comando = new SqlCommand(sql, conexion)){
                    using(SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read()){
                            MarcaEncontrada = new Marca()
                            {
                                Id = Int32.Parse( resultado["id"].ToString()),
                                nombre = (string)resultado["nombre"]
                            };
                            MarcasEncontradas.Add(MarcaEncontrada);
                        }
                    }
                }
            }
            return MarcasEncontradas;
        }
    }
}