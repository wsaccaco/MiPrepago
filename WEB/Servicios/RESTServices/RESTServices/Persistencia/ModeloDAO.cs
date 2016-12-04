using RESTServices.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RESTServices.Persistencia
{
    public class ModeloDAO
    {
        public List<Modelo> ListarModelos(string nombre_marca)
        {
            List<Modelo> ModelosEncontrados = new List<Modelo>();
            Modelo ModeloEncontrada = null;
            string sql = "select mo.id,mo.nombre,cast(mo.anio as varchar) anio,mo.precio,mo.stock,mo.marca_id   from modelo mo inner join marca ma ON mo.marca_id = ma.id where ma.nombre = @nombreMarca";
            using (SqlConnection conexion = new SqlConnection(utilConexion.CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@nombreMarca", nombre_marca));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            ModeloEncontrada = new Modelo()
                            {
                                id = Int32.Parse(resultado["id"].ToString()),
                                nombre = (string)resultado["nombre"],
                                precio = float.Parse(resultado["precio"].ToString()),
                                stock = Int32.Parse(resultado["stock"].ToString()),
                                marcaId = Int32.Parse(resultado["marca_id"].ToString()),
                                anio= (string)resultado["anio"]

                            };
                            ModelosEncontrados.Add(ModeloEncontrada);
                        }
                    }
                }
            }
            return ModelosEncontrados;
        }


        public Modelo obtener(int Id)
        {
            Modelo ModeloEncontrado = null;
            string sql = "SELECT * FROM modelo WHERE id = @id";
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
                            ModeloEncontrado = new Modelo()
                            {
                                id = Int32.Parse(resultado["id"].ToString()),
                                nombre = (string)resultado["nombre"],
                                stock = Int32.Parse(resultado["stock"].ToString()),
                                marcaId = Int32.Parse(resultado["marca_id"].ToString()),
                                precio = float.Parse(resultado["precio"].ToString())
                            };
                        }
                    }
                }
            }

            return ModeloEncontrado;
        }


        public List<Modelo> ListarModelo(string nombre_modelo, string nombre_marca)
        {
            List<Modelo> ModelosEncontrados = new List<Modelo>();
            Modelo ModeloEncontrada = null;
            string sql = "select * from modelo mo inner join marca ma ON mo.marca_id = ma.id where ma.nombre = @nombreMarca and mo.nombre = @nombreModelo";
            using (SqlConnection conexion = new SqlConnection(utilConexion.CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@nombreMarca", nombre_marca));
                    comando.Parameters.Add(new SqlParameter("@nombreModelo", nombre_modelo));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            ModeloEncontrada = new Modelo()
                            {
                                id = Int32.Parse(resultado["id"].ToString()),
                                nombre = (string)resultado["nombre"],
                                precio = float.Parse(resultado["precio"].ToString()),
                                stock = Int32.Parse(resultado["stock"].ToString()),
                                marcaId = Int32.Parse(resultado["marca_id"].ToString())
                            };
                            ModelosEncontrados.Add(ModeloEncontrada);
                        }
                    }
                }
            }
            return ModelosEncontrados;
        }


    }
}