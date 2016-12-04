using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.ServiceModel;

namespace WCFServiceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ModeloWS.SmodeloClient proxy = new ModeloWS.SmodeloClient();
            ModeloWS.Modelo[] ListaModelos = proxy.Listado_ModeloxMarca_Proveedor("xiaomi");
            Assert.AreEqual("MiNote", ListaModelos[0].nombre);
        }


        [TestMethod]
        public void TestMethod2()
        {
            ModeloWS.SmodeloClient proxy = new ModeloWS.SmodeloClient();
            try
            {
                ModeloWS.Modelo[] ListaModelos = proxy.Listado_ModeloxMarca_Proveedor("Microsoft");
            }
            catch (FaultException<ModeloWS.ExceptionGeneral> error) {

                Assert.AreEqual("No se aceptan estas marcas", error.Reason);
                Assert.AreEqual(error.Detail.codigo, "1");
                Assert.AreEqual(error.Detail.descripcion, "Error 404");

            }

        }

    }
}
