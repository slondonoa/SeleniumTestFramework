using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumFramework.Common;

namespace AviancaTest
{
    [TestClass]
    public class PaymentRetryUnitTest
    {

        [TestMethod]
        public void B2B_Retry_Payment_Case_1_Espanol()
        {
            #region Arrange
            string url = "http://localhost/B2B/";
            string PageTitle = "Avianca";

            Browser.setDriver = @"C:\WebDrivers\chromedriver\2.3";
            SitePages.RunEvents.TimeOut = 30;

            SitePages.RunEvents.GoTo(url);
            Assert.IsTrue(SitePages.RunEvents.IsAt(PageTitle));

            string ScreenShotPath = @"C:\Evidencias\B2B\Caso1\";
            #endregion

            #region  Action
            //Llenar datos formulario inicial para buscar vuelos
            SitePages.RunEvents.SelectListElementByValue("Pais", "Name", "ES");
            SitePages.RunEvents.SelectListElementByValue("lan", "Name", "ES");
            SitePages.RunEvents.SelectListElementByValue("cco", "Name", "MDE");
            SitePages.RunEvents.SelectListElementByValue("ccd", "Name", "CTG");
            SitePages.RunEvents.TextToElement("fi", "Name", "22JUN");
            SitePages.RunEvents.TextToElement("fr", "Name", "28JUN");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("//input[@value='Buscar Vuelos']", "XPath");


            //confimar vuelos y horarios 
            SitePages.RunEvents.SwitchToFrame("formDefault2,Name|FrameAmadeus,Id");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("btnSelect", "Id");


            //confirmar detalles del vuelo 
            SitePages.RunEvents.SwitchToFrame("formDefault2,Name|FrameAmadeus,Id");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("btnTravellerDetailsFare", "Id");


            //llenar datos del viajero
            SitePages.RunEvents.SwitchToFrame("formDefault2,Name|FrameAmadeus,Id");
            SitePages.RunEvents.TextToElement("TxtBxApellido", "Id", "prueba");
            SitePages.RunEvents.TextToElement("TxtBxNombre", "Id", "prueba");
            SitePages.RunEvents.TextToElement("TxtBxCorreo", "Id", "preuba@prueba1.com");
            SitePages.RunEvents.TextToElement("TxtBxTelefono", "Id", "1234567");
            SitePages.RunEvents.ClickElement("lschkPoliticaCondiciones_0", "Id");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("btnPagarContinuar1", "Id");

            //Complementar datos del viajero 
            SitePages.RunEvents.SwitchToFrame("formDefault2,Name|FrameAmadeus,Id");
            SitePages.RunEvents.TextToElement("paxDobYear_1", "Id", "1988");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("btnPurchaseAlpi", "Id");


            //Confirmacion del viaje
            SitePages.RunEvents.SwitchToFrame("formDefault2,Name|FrameAmadeus,Id");
            SitePages.RunEvents.ClickElement("return_policy_checkbox_input", "Id");
            SitePages.RunEvents.ClickElement("CheckPenaliesBox", "Id");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("btnConfirmPurc", "Id");


            //Datos titular tarjeta
            SitePages.RunEvents.TextToElement("RVLDatosTarjetaHabiente1_txtApellido", "Id", "prueba");
            SitePages.RunEvents.TextToElement("RVLDatosTarjetaHabiente1_txtNombreCompleto", "Id", "prueba");
            //SitePages.RunEvents.SelectListElementByText("RVLDatosTarjetaHabiente1_ddlTipoDocId", "Id", "Cédula");
            SitePages.RunEvents.SelectListElementByValue("RVLDatosTarjetaHabiente1_ddlTipoDocId", "Id", "2");
            SitePages.RunEvents.TextToElement("RVLDatosTarjetaHabiente1_txtNumIdentificacion", "Id", "1234567890");
            SitePages.RunEvents.TextToElement("RVLDatosTarjetaHabiente1_txtEmail", "Id", "prueba@prueba.com");
            SitePages.RunEvents.TextToElement("RVLDatosTarjetaHabiente1_txtTelefono", "Id", "1234567");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            //Datos de la tarjeta 
            //SitePages.RunEvents.SelectListElementByText("RVLTarjetas1_ddlTipoTarjeta", "Id", "VISA");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetas1_ddlTipoTarjeta", "Id", "1");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtNumeroTarjeta", "Id", "4111111111111111");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetas1_ddlMes", "Id", "12");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetas1_ddlAnio", "Id", "2019");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_TxtBxBanco", "Id", "bancolombia");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtCVV_CSS", "Id", "123");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            //Datos domicilio 
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtDireccion", "Id", "carrera");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtDireccion2", "Id", "carrera 2");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtTelefono", "Id", "1234567");
            //SitePages.RunEvents.SelectListElementByText("RVLTarjetas1_ddlPais", "Id", "Colombia");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetas1_ddlPais", "Id", "CO");
            SitePages.RunEvents.LoaStandby(2000);
            SitePages.RunEvents.TextToElement("RVLTarjetas1_TxtCiudad", "Id", "medellin");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtEstado", "Id", "medellin");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtCodigoZip", "Id", "12345");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            //confirmar pago 
            SitePages.RunEvents.ClickElement("btnPagarTCNew", "Id");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            #endregion

            #region  Assert
            //Assert.AreEqual("Transacción rechazada", SitePages.RunEvents.FindTextElement("DxReintentoPago_lblTituloReintentoPago", "Id"));
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            #endregion

            //Reintentar pago 
            //while (SitePages.RunEvents.ElementPresent("btnReintentar", "Id"))
            //{
            //    SitePages.RunEvents.ElementPresent("btnReintentar", "Id");
            //}
            SitePages.RunEvents.LoaStandby(60000);

            SitePages.RunEvents.ClickElement("btnReintentar", "Id");
            SitePages.RunEvents.LoaStandby(2000);

            //Cambio datos de tarjeta 
            SitePages.RunEvents.SwitchToFrame("formDefault2,Name|FrameAmadeus,Id");
            //SitePages.RunEvents.SelectListElementByText("RVLTarjetas1_ddlTipoTarjeta", "Id", "VISA");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetas1_ddlTipoTarjeta", "Id", "1");
            SitePages.RunEvents.LoaStandby(2000);
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtNumeroTarjeta", "Id", "4111111111111111");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetas1_ddlMes", "Id", "12");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetas1_ddlAnio", "Id", "2019");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_TxtBxBanco", "Id", "bancolombia");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtCVV_CSS", "Id", "123");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            //reinterar pago 
            SitePages.RunEvents.ClickElement("btnPagarTCNew", "Id");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

        }


        [TestMethod]
        public void B2B_Retry_Payment_Case_1_Ingles()
        {
            #region Arrange
            string url = "http://localhost/B2B/";
            string PageTitle = "Avianca";

            Browser.setDriver = @"C:\WebDrivers\chromedriver\2.3";
            SitePages.RunEvents.TimeOut = 30;

            SitePages.RunEvents.GoTo(url);
            Assert.IsTrue(SitePages.RunEvents.IsAt(PageTitle));

            string ScreenShotPath = @"C:\Evidencias\B2B\Caso1\";
            #endregion

            #region  Action
            //Llenar datos formulario inicial para buscar vuelos
            SitePages.RunEvents.SelectListElementByValue("Pais", "Name", "ES");
            SitePages.RunEvents.SelectListElementByValue("lan", "Name", "EN");
            SitePages.RunEvents.SelectListElementByValue("cco", "Name", "MDE");
            SitePages.RunEvents.SelectListElementByValue("ccd", "Name", "CTG");
            SitePages.RunEvents.TextToElement("fi", "Name", "22JUN");
            SitePages.RunEvents.TextToElement("fr", "Name", "28JUN");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("//input[@value='Buscar Vuelos']", "XPath");


            //confimar vuelos y horarios 
            SitePages.RunEvents.SwitchToFrame("formDefault2,Name|FrameAmadeus,Id");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("btnSelect", "Id");


            //confirmar detalles del vuelo 
            SitePages.RunEvents.SwitchToFrame("formDefault2,Name|FrameAmadeus,Id");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("btnTravellerDetailsFare", "Id");


            //llenar datos del viajero
            SitePages.RunEvents.SwitchToFrame("formDefault2,Name|FrameAmadeus,Id");
            SitePages.RunEvents.TextToElement("TxtBxApellido", "Id", "prueba");
            SitePages.RunEvents.TextToElement("TxtBxNombre", "Id", "prueba");
            SitePages.RunEvents.TextToElement("TxtBxCorreo", "Id", "preuba@prueba1.com");
            SitePages.RunEvents.TextToElement("TxtBxTelefono", "Id", "1234567");
            SitePages.RunEvents.ClickElement("lschkPoliticaCondiciones_0", "Id");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("btnPagarContinuar1", "Id");

            //Complementar datos del viajero 
            SitePages.RunEvents.SwitchToFrame("formDefault2,Name|FrameAmadeus,Id");
            SitePages.RunEvents.TextToElement("paxDobYear_1", "Id", "1988");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("btnPurchaseAlpi", "Id");


            //Confirmacion del viaje
            SitePages.RunEvents.SwitchToFrame("formDefault2,Name|FrameAmadeus,Id");
            SitePages.RunEvents.ClickElement("return_policy_checkbox_input", "Id");
            SitePages.RunEvents.ClickElement("CheckPenaliesBox", "Id");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("btnConfirmPurc", "Id");


            //Datos titular tarjeta
            SitePages.RunEvents.TextToElement("RVLDatosTarjetaHabiente1_txtApellido", "Id", "prueba");
            SitePages.RunEvents.TextToElement("RVLDatosTarjetaHabiente1_txtNombreCompleto", "Id", "prueba");
            //SitePages.RunEvents.SelectListElementByText("RVLDatosTarjetaHabiente1_ddlTipoDocId", "Id", "Cédula");
            SitePages.RunEvents.SelectListElementByValue("RVLDatosTarjetaHabiente1_ddlTipoDocId", "Id", "2");
            SitePages.RunEvents.TextToElement("RVLDatosTarjetaHabiente1_txtNumIdentificacion", "Id", "1234567890");
            SitePages.RunEvents.TextToElement("RVLDatosTarjetaHabiente1_txtEmail", "Id", "prueba@prueba.com");
            SitePages.RunEvents.TextToElement("RVLDatosTarjetaHabiente1_txtTelefono", "Id", "1234567");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            //Datos de la tarjeta 
            //SitePages.RunEvents.SelectListElementByText("RVLTarjetas1_ddlTipoTarjeta", "Id", "VISA");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetas1_ddlTipoTarjeta", "Id", "1");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtNumeroTarjeta", "Id", "4111111111111111");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetas1_ddlMes", "Id", "12");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetas1_ddlAnio", "Id", "2019");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_TxtBxBanco", "Id", "bancolombia");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtCVV_CSS", "Id", "123");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            //Datos domicilio 
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtDireccion", "Id", "carrera");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtDireccion2", "Id", "carrera 2");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtTelefono", "Id", "1234567");
            //SitePages.RunEvents.SelectListElementByText("RVLTarjetas1_ddlPais", "Id", "Colombia");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetas1_ddlPais", "Id", "CO");
            SitePages.RunEvents.LoaStandby(2000);
            SitePages.RunEvents.TextToElement("RVLTarjetas1_TxtCiudad", "Id", "medellin");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtEstado", "Id", "medellin");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtCodigoZip", "Id", "12345");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            //confirmar pago 
            SitePages.RunEvents.ClickElement("btnPagarTCNew", "Id");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            #endregion

            #region  Assert
            //Assert.AreEqual("Transacción rechazada", SitePages.RunEvents.FindTextElement("DxReintentoPago_lblTituloReintentoPago", "Id"));
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            #endregion

            //Reintentar pago 
            //while (SitePages.RunEvents.ElementPresent("btnReintentar", "Id"))
            //{
            //    SitePages.RunEvents.ElementPresent("btnReintentar", "Id");
            //}
            SitePages.RunEvents.LoaStandby(60000);

            SitePages.RunEvents.ClickElement("btnReintentar", "Id");
            SitePages.RunEvents.LoaStandby(2000);

            //Cambio datos de tarjeta 
            SitePages.RunEvents.SwitchToFrame("formDefault2,Name|FrameAmadeus,Id");
            //SitePages.RunEvents.SelectListElementByText("RVLTarjetas1_ddlTipoTarjeta", "Id", "VISA");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetas1_ddlTipoTarjeta", "Id", "1");
            SitePages.RunEvents.LoaStandby(2000);
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtNumeroTarjeta", "Id", "4111111111111111");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetas1_ddlMes", "Id", "12");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetas1_ddlAnio", "Id", "2019");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_TxtBxBanco", "Id", "bancolombia");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtCVV_CSS", "Id", "123");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            //reinterar pago 
            SitePages.RunEvents.ClickElement("btnPagarTCNew", "Id");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

        }

        [TestMethod]
        public void B2B_Cancel_Retry_Payment_Case_1_Espanol()
        {
            #region Arrange
            string url = "http://localhost/B2B/";
            string PageTitle = "Avianca";

            Browser.setDriver = @"C:\WebDrivers\chromedriver\2.3";
            SitePages.RunEvents.TimeOut = 30;

            SitePages.RunEvents.GoTo(url);
            Assert.IsTrue(SitePages.RunEvents.IsAt(PageTitle));

            string ScreenShotPath = @"C:\Evidencias\B2B\Caso1\";
            #endregion

            #region  Action
            //Llenar datos formulario inicial para buscar vuelos
            SitePages.RunEvents.SelectListElementByValue("Pais", "Name", "ES");
            SitePages.RunEvents.SelectListElementByValue("lan", "Name", "ES");
            SitePages.RunEvents.SelectListElementByValue("cco", "Name", "MDE");
            SitePages.RunEvents.SelectListElementByValue("ccd", "Name", "CTG");
            SitePages.RunEvents.TextToElement("fi", "Name", "22JUN");
            SitePages.RunEvents.TextToElement("fr", "Name", "28JUN");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("//input[@value='Buscar Vuelos']", "XPath");


            //confimar vuelos y horarios 
            SitePages.RunEvents.SwitchToFrame("formDefault2,Name|FrameAmadeus,Id");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("btnSelect", "Id");


            //confirmar detalles del vuelo 
            SitePages.RunEvents.SwitchToFrame("formDefault2,Name|FrameAmadeus,Id");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("btnTravellerDetailsFare", "Id");


            //llenar datos del viajero
            SitePages.RunEvents.SwitchToFrame("formDefault2,Name|FrameAmadeus,Id");
            SitePages.RunEvents.TextToElement("TxtBxApellido", "Id", "prueba");
            SitePages.RunEvents.TextToElement("TxtBxNombre", "Id", "prueba");
            SitePages.RunEvents.TextToElement("TxtBxCorreo", "Id", "preuba@prueba1.com");
            SitePages.RunEvents.TextToElement("TxtBxTelefono", "Id", "1234567");
            SitePages.RunEvents.ClickElement("lschkPoliticaCondiciones_0", "Id");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("btnPagarContinuar1", "Id");

            //Complementar datos del viajero 
            SitePages.RunEvents.SwitchToFrame("formDefault2,Name|FrameAmadeus,Id");
            SitePages.RunEvents.TextToElement("paxDobYear_1", "Id", "1988");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("btnPurchaseAlpi", "Id");


            //Confirmacion del viaje
            SitePages.RunEvents.SwitchToFrame("formDefault2,Name|FrameAmadeus,Id");
            SitePages.RunEvents.ClickElement("return_policy_checkbox_input", "Id");
            SitePages.RunEvents.ClickElement("CheckPenaliesBox", "Id");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("btnConfirmPurc", "Id");


            //Datos titular tarjeta
            SitePages.RunEvents.TextToElement("RVLDatosTarjetaHabiente1_txtApellido", "Id", "prueba");
            SitePages.RunEvents.TextToElement("RVLDatosTarjetaHabiente1_txtNombreCompleto", "Id", "prueba");
            //SitePages.RunEvents.SelectListElementByText("RVLDatosTarjetaHabiente1_ddlTipoDocId", "Id", "Cédula");
            SitePages.RunEvents.SelectListElementByValue("RVLDatosTarjetaHabiente1_ddlTipoDocId", "Id", "2");
            SitePages.RunEvents.TextToElement("RVLDatosTarjetaHabiente1_txtNumIdentificacion", "Id", "1234567890");
            SitePages.RunEvents.TextToElement("RVLDatosTarjetaHabiente1_txtEmail", "Id", "prueba@prueba.com");
            SitePages.RunEvents.TextToElement("RVLDatosTarjetaHabiente1_txtTelefono", "Id", "1234567");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            //Datos de la tarjeta 
            //SitePages.RunEvents.SelectListElementByText("RVLTarjetas1_ddlTipoTarjeta", "Id", "VISA");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetas1_ddlTipoTarjeta", "Id", "1");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtNumeroTarjeta", "Id", "4111111111111111");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetas1_ddlMes", "Id", "12");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetas1_ddlAnio", "Id", "2019");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_TxtBxBanco", "Id", "bancolombia");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtCVV_CSS", "Id", "123");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            //Datos domicilio 
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtDireccion", "Id", "carrera");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtDireccion2", "Id", "carrera 2");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtTelefono", "Id", "1234567");
            //SitePages.RunEvents.SelectListElementByText("RVLTarjetas1_ddlPais", "Id", "Colombia");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetas1_ddlPais", "Id", "CO");
            SitePages.RunEvents.LoaStandby(2000);
            SitePages.RunEvents.TextToElement("RVLTarjetas1_TxtCiudad", "Id", "medellin");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtEstado", "Id", "medellin");
            SitePages.RunEvents.TextToElement("RVLTarjetas1_txtCodigoZip", "Id", "12345");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            //confirmar pago 
            SitePages.RunEvents.ClickElement("btnPagarTCNew", "Id");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            #endregion

            #region  Assert
            //Assert.AreEqual("Transacción rechazada", SitePages.RunEvents.FindTextElement("DxReintentoPago_lblTituloReintentoPago", "Id"));
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            #endregion

            //Reintentar pago 
            //while (SitePages.RunEvents.ElementPresent("btnReintentar", "Id"))
            //{
            //    SitePages.RunEvents.ElementPresent("btnReintentar", "Id");
            //}
            SitePages.RunEvents.LoaStandby(60000);
            SitePages.RunEvents.ClickElement("btnCancelar", "Id");

            SitePages.RunEvents.LoaStandby(4000);
            SitePages.RunEvents.SwitchToFrame("formDefault2,Name|FrameAmadeus,Id");
            Assert.AreEqual("Su solicitud de compra ha sido rechazada. Las condiciones de la tarifa pueden variar, te recomendamos acercarte a una oficina de venta o comunícate a nuestro call center para asesorarte en este proceso.",
                SitePages.RunEvents.FindTextElement("lblMensajeErrorTC", "Id"));


        }

    }
}
