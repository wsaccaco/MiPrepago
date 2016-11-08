using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace u201522215
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Tools" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Tools.svc o Tools.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Tools : ITools
    {
        public string calcular(int Number)
        {
           
            return Number.ToString();
            
        }
    }
}
