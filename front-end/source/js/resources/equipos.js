
module.exports = (function(){
    return {
        getMarca: function () {

            var bhRequest = '<s:Envelope xmlns:s="http://schemas.xmlsoap.org/soap/envelope/">' +
                '<s:Header>' +
                '<Action s:mustUnderstand="1" xmlns="http://schemas.microsoft.com/ws/2005/05/addressing/none">http://tempuri.org/IMarcas/listarMarca</Action>' +
                '</s:Header>' +
                '<s:Body>' +
                '<listarMarca xmlns="http://tempuri.org/" />' +
                '</s:Body>' +
                '</s:Envelope>';

            $.ajax({
                type: "POST",
                url: 'http://localhost:60184/Marcas.svc?wsdl',
                data: bhRequest,
                timeout: 10000,
                crossDomain: true,
                contentType: "text/plain, charset=utf-8",
                dataType: "xml",
                beforeSend: function (xhr) {
                    xhr.setRequestHeader("SOAPAction", "http://tempuri.org/IMarcas/listarMarca");
                },
                success:function (soapResponse) {
                    console.log(soapResponse)
                }
            })
        }
    }
})();
