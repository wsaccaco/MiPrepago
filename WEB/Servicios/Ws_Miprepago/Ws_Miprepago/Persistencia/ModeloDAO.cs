using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WS_MiPrepago.Dominio;

namespace WS_MiPrepago.Persistencia
{
    public class ModeloDAO
    {
        private string cadenaConexion = @"Server=localhost;Database=BD_MiPrepago;Trusted_Connection=True;";

        public Modelo crear(Modelo modeloACrear)
        {
            Modelo modeloCreado = null;
            string sql = "INSERT INTO modelo VALUES(@modelo_id, @nombre,@marca_marca_id)";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@modelo_id", modeloACrear.modelo_id));
                    comando.Parameters.Add(new SqlParameter("@nombre", modeloACrear.nombre));
                    comando.Parameters.Add(new SqlParameter("@marca_marca_id", modeloACrear.marca_marca_id));
                    comando.ExecuteNonQuery();
                }
            }
            modeloCreado= obtener(modeloACrear.modelo_id);
            return modeloCreado;
        }

        public Modelo obtener(int Id)
        {
            Modelo modeloEncontrado= null;
            string sql = "SELECT * FROM modelo WHERE modelo_id = @id";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", Id));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            modeloEncontrado = new Modelo()
                            {
                                modelo_id= Int32.Parse(resultado["modelo_id"].ToString()),
                                nombre = (string)resultado["nombre"] ,
                                marca_marca_id= Int32.Parse(resultado["marca_marca_id"].ToString())
                            };
                        }
                    }
                }
            }

            return modeloEncontrado;
        }

        public Modelo modificar(Modelo modeloAModificar)
        {
            Modelo modeloModificado= null;
            string sql = "";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@modelo_id", modeloAModificar.modelo_id));
                    comando.Parameters.Add(new SqlParameter("@nombre", modeloAModificar.nombre));
                    comando.Parameters.Add(new SqlParameter("@marca_marca_id", modeloAModificar.marca_marca_id));
                    comando.ExecuteNonQuery();
                }
            }
            modeloModificado = obtener(modeloAModificar.modelo_id);
            return modeloModificado;
        }

        public List<Modelo> Listar()
        {
            List<Modelo> modelosEncontrados= new List<Modelo>();
            Modelo modeloEncontrado = null;
            string sql = "SELECT * FROM modelo";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            modeloEncontrado= new Modelo()
                            {
                                modelo_id = Int32.Parse(resultado["modelo_id"].ToString()),
                                nombre = (string)resultado["nombre"],
                                marca_marca_id = Int32.Parse(resultado["marca_marca_id"].ToString())
                            };
                            modelosEncontrados.Add(modeloEncontrado);
                        }
                    }
                }
            }
            return modelosEncontrados;
        }

    }
}