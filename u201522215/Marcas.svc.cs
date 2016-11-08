using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using u201522215.Dominio;
using u201522215.Errores;
using u201522215.Persistencia;

namespace u201522215
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Perdidas" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Perdidas.svc o Perdidas.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Perdidas : IMarcas
    {
        private MarcaDAO marcaDAO = new MarcaDAO();

        public string calcular(int number)
        {
            Tools tools = new Tools();
            return tools.calcular(number);
        }

        public Marca crearMarca(Marca marcaACrear)
        {
            if (marcaDAO.obtener(marcaACrear.marca_id) != null){
                throw new FaultException<RepetidoException>(
                    new RepetidoException()
                    {
                        codigo = "101",
                        descripcion = "error"
                    }, new FaultReason("error por una razon"));
            }
            return marcaDAO.crear(marcaACrear);
        }

        public Marca ObtenerMarca(int Id)
        {
            return marcaDAO.obtener(Id);
        }

        public List<Marca> listarMarca()
        {
            return marcaDAO.Listar();
        }
    }
}
