using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using u201522215.Dominio;
using u201522215.Errores;

namespace u201522215
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPerdidas" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMarcas
    {
        [FaultContract(typeof(RepetidoException))]
        [OperationContract]
        Marca crearMarca(Marca marcaACrear);

        [OperationContract]
        Marca ObtenerMarca(int Id);

        [OperationContract]
        List<Marca> listarMarca();

        [OperationContract]
        string calcular(int number);
    }
}
