using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_MiPrepago.Dominio;
using WS_MiPrepago.Errores;
using WS_MiPrepago.Persistencia;

namespace WS_MiPrepago
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Smodelo" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Smodelo.svc or Smodelo.svc.cs at the Solution Explorer and start debugging.
    public class Smodelo : ISmodelo
    {
        private ModeloDAO modeloDAO = new ModeloDAO();

        public string calcular(int number)
        {
            Tools tools = new Tools();
            return tools.calcular(number);
        }

        public Modelo crearModelo(Modelo modeloCrear)
        {
            if (modeloDAO.obtener(modeloCrear.modelo_id) != null)
            {
                throw new FaultException<ModeloRepetidoException>(
                    new ModeloRepetidoException()
                    {
                        modelo_id = "101",
                        nombre = "error",
                        marca_marca_id = "1"
                    }, new FaultReason("error por una razon"));
            }
            return modeloDAO.crear(modeloCrear);
        }

    

        public List<Modelo> listarModelo()
        {
            return modeloDAO.Listar();
        }

        public Modelo obtenerModelo(int Id)
        {
 
            return modeloDAO.obtener(Id);
    }
    }
}
