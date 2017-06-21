using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumFramework.Common;

namespace AviancaTest.B2C
{
    [TestClass]
    public class PaymentRetryUnitTest
    {
        [TestMethod]
        public void B2C_Retry_Payment_Case_1_Espanol()
        {
            #region Arrange
            string url = "http://localhost/B2C/";
            string PageTitle = "Avianca";

            Browser.setDriver = @"C:\WebDrivers\chromedriver\2.3";
            SitePages.RunEvents.TimeOut = 30;

            SitePages.RunEvents.GoTo(url);
            Assert.IsTrue(SitePages.RunEvents.IsAt(PageTitle));
            string ScreenShotPath = @"C:\Evidencias\B2C\";
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
            SitePages.RunEvents.LoaStandby(10000);
            SitePages.RunEvents.SwitchToFrame("FrameAmadeus,Id");

            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            SitePages.RunEvents.EnterElement("w63", "Id");

            //llenar datos del viajero
            SitePages.RunEvents.SwitchToFrame("FrameAmadeus,Id");
            SitePages.RunEvents.TextToElement("txtApellidoViajero", "Id", "prueba");
            SitePages.RunEvents.TextToElement("txtNombreViajero", "Id", "prueba");
            SitePages.RunEvents.TextToElement("txtMailViajero", "Id", "preuba@prueba1.com");
            SitePages.RunEvents.TextToElement("txtTelefonoViajero", "Id", "1234567");
            SitePages.RunEvents.ClickElement("chkPoliticas", "Id");

            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            SitePages.RunEvents.ClickElement("btnContinuar", "Id");

            //Complementar datos del viajero 
            SitePages.RunEvents.SwitchToFrame("FrameAmadeus,Id");
            SitePages.RunEvents.TextToElement("tpl3_widget-input-travellerList-traveller_0_ADT-IDEN_DateOfBirth-DateDay", "Id", "25");
            SitePages.RunEvents.SelectListElementByValue("tpl3_widget-input-travellerList-traveller_0_ADT-IDEN_DateOfBirth-DateMonth", "Id", "12");
            SitePages.RunEvents.TextToElement("tpl3_widget-input-travellerList-traveller_0_ADT-IDEN_DateOfBirth-DateYear", "Id", "1988");

            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            SitePages.RunEvents.EnterElement("w33", "Id");

            //Confirmacion del viaje
            SitePages.RunEvents.SwitchToFrame("FrameAmadeus,Id");

            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            SitePages.RunEvents.EnterElement("w35", "Id");

            //Terminos y condiciones
            SitePages.RunEvents.SwitchToFrame("FrameAmadeus,Id");
            SitePages.RunEvents.ClickElement("w12_widget-input-purchaseForm-termsConditionsForm-termsAndCondition", "Id");
            SitePages.RunEvents.ClickElement("w12_widget-input-purchaseForm-termsConditionsForm-additionalTermsAndCondition", "Id");

            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            SitePages.RunEvents.EnterElement("w32", "Id");

            //Datos medio de pago 
            SitePages.RunEvents.TextToElement("DxRvlDatosTarjetaHabienteCredito_txtApellido", "Id", "prueba");
            SitePages.RunEvents.TextToElement("DxRvlDatosTarjetaHabienteCredito_txtNombreCompleto", "Id", "prueba");
            SitePages.RunEvents.SelectListElementByValue("DxRvlDatosTarjetaHabienteCredito_ddlTipoDocId", "Id", "2");
            SitePages.RunEvents.TextToElement("DxRvlDatosTarjetaHabienteCredito_txtNumIdentificacion", "Id", "1234567890");
            SitePages.RunEvents.TextToElement("DxRvlDatosTarjetaHabienteCredito_txtEmail", "Id", "prueba@prueba.com");
            SitePages.RunEvents.TextToElement("DxRvlDatosTarjetaHabienteCredito_txtTelefono", "Id", "1234567");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetasCredito_ddlTipoTarjeta", "Id", "1");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtNumeroTarjeta", "Id", "4111111111111111");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetasCredito_ddlMes", "Id", "12");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetasCredito_ddlAnio", "Id", "2019");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_TxtBxBanco", "Id", "bancolombia");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtCVV_CSS", "Id", "123");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtDireccion", "Id", "carrera");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtDireccion2", "Id", "carrera 2");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtTelefono", "Id", "1234567");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetasCredito_ddlPais", "Id", "ES");
            SitePages.RunEvents.LoaStandby(2000);
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_TxtCiudad", "Id", "medellin");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtEstado", "Id", "medellin");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtCodigoZip", "Id", "12345");

            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            SitePages.RunEvents.ClickElement("btnPagarTcNew", "Id");

            //Confirmar pago 
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            SitePages.RunEvents.ClickElement("BtnContinuarPagoNew", "Id");

            SitePages.RunEvents.LoaStandby(40000);

            SitePages.RunEvents.ClickElement("btnReintentar", "Id");
            SitePages.RunEvents.LoaStandby(2000);
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetasCredito_ddlTipoTarjeta", "Id", "1");
            SitePages.RunEvents.LoaStandby(2000);
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtNumeroTarjeta", "Id", "4111111111111111");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetasCredito_ddlMes", "Id", "12");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetasCredito_ddlAnio", "Id", "2019");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_TxtBxBanco", "Id", "bancolombia");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtCVV_CSS", "Id", "123");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("btnPagarTcNew", "Id");
            //Confirmar pago 
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("BtnContinuarPagoNew", "Id");

            #endregion

            //#region  Assert
            //Assert.AreEqual("Transacción rechazada", SitePages.RunEvents.FindTextElement("DxReintentoPago_lblTituloReintentoPago", "Id"));
            //#endregion
        }

        [TestMethod]
        public void B2C_Retry_Payment_Case_1_Ingles()
        {
            #region Arrange
            string url = "http://localhost/B2C/";
            string PageTitle = "Avianca";

            Browser.setDriver = @"C:\WebDrivers\chromedriver\2.3";
            SitePages.RunEvents.TimeOut = 30;

            SitePages.RunEvents.GoTo(url);
            Assert.IsTrue(SitePages.RunEvents.IsAt(PageTitle));
            string ScreenShotPath = @"C:\Evidencias\B2C\";
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
            SitePages.RunEvents.LoaStandby(10000);
            SitePages.RunEvents.SwitchToFrame("FrameAmadeus,Id");

            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            SitePages.RunEvents.EnterElement("w63", "Id");

            //llenar datos del viajero
            SitePages.RunEvents.SwitchToFrame("FrameAmadeus,Id");
            SitePages.RunEvents.TextToElement("txtApellidoViajero", "Id", "prueba");
            SitePages.RunEvents.TextToElement("txtNombreViajero", "Id", "prueba");
            SitePages.RunEvents.TextToElement("txtMailViajero", "Id", "preuba@prueba1.com");
            SitePages.RunEvents.TextToElement("txtTelefonoViajero", "Id", "1234567");
            SitePages.RunEvents.ClickElement("chkPoliticas", "Id");

            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            SitePages.RunEvents.ClickElement("btnContinuar", "Id");

            //Complementar datos del viajero 
            SitePages.RunEvents.SwitchToFrame("FrameAmadeus,Id");
            SitePages.RunEvents.TextToElement("tpl3_widget-input-travellerList-traveller_0_ADT-IDEN_DateOfBirth-DateDay", "Id", "25");
            SitePages.RunEvents.SelectListElementByValue("tpl3_widget-input-travellerList-traveller_0_ADT-IDEN_DateOfBirth-DateMonth", "Id", "12");
            SitePages.RunEvents.TextToElement("tpl3_widget-input-travellerList-traveller_0_ADT-IDEN_DateOfBirth-DateYear", "Id", "1988");

            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            SitePages.RunEvents.EnterElement("w33", "Id");

            //Confirmacion del viaje
            SitePages.RunEvents.SwitchToFrame("FrameAmadeus,Id");

            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            SitePages.RunEvents.EnterElement("w35", "Id");

            //Terminos y condiciones
            SitePages.RunEvents.SwitchToFrame("FrameAmadeus,Id");
            SitePages.RunEvents.ClickElement("w12_widget-input-purchaseForm-termsConditionsForm-termsAndCondition", "Id");
            SitePages.RunEvents.ClickElement("w12_widget-input-purchaseForm-termsConditionsForm-additionalTermsAndCondition", "Id");

            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            SitePages.RunEvents.EnterElement("w32", "Id");

            //Datos medio de pago 
            SitePages.RunEvents.TextToElement("DxRvlDatosTarjetaHabienteCredito_txtApellido", "Id", "prueba");
            SitePages.RunEvents.TextToElement("DxRvlDatosTarjetaHabienteCredito_txtNombreCompleto", "Id", "prueba");
            SitePages.RunEvents.SelectListElementByValue("DxRvlDatosTarjetaHabienteCredito_ddlTipoDocId", "Id", "2");
            SitePages.RunEvents.TextToElement("DxRvlDatosTarjetaHabienteCredito_txtNumIdentificacion", "Id", "1234567890");
            SitePages.RunEvents.TextToElement("DxRvlDatosTarjetaHabienteCredito_txtEmail", "Id", "prueba@prueba.com");
            SitePages.RunEvents.TextToElement("DxRvlDatosTarjetaHabienteCredito_txtTelefono", "Id", "1234567");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetasCredito_ddlTipoTarjeta", "Id", "1");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtNumeroTarjeta", "Id", "4111111111111111");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetasCredito_ddlMes", "Id", "12");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetasCredito_ddlAnio", "Id", "2019");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_TxtBxBanco", "Id", "bancolombia");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtCVV_CSS", "Id", "123");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtDireccion", "Id", "carrera");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtDireccion2", "Id", "carrera 2");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtTelefono", "Id", "1234567");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetasCredito_ddlPais", "Id", "ES");
            SitePages.RunEvents.LoaStandby(2000);
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_TxtCiudad", "Id", "medellin");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtEstado", "Id", "medellin");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtCodigoZip", "Id", "12345");

            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            SitePages.RunEvents.ClickElement("btnPagarTcNew", "Id");

            //Confirmar pago 
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            SitePages.RunEvents.ClickElement("BtnContinuarPagoNew", "Id");

            SitePages.RunEvents.LoaStandby(40000);

            SitePages.RunEvents.ClickElement("btnReintentar", "Id");
            SitePages.RunEvents.LoaStandby(2000);
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetasCredito_ddlTipoTarjeta", "Id", "1");
            SitePages.RunEvents.LoaStandby(2000);
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtNumeroTarjeta", "Id", "4111111111111111");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetasCredito_ddlMes", "Id", "12");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetasCredito_ddlAnio", "Id", "2019");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_TxtBxBanco", "Id", "bancolombia");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtCVV_CSS", "Id", "123");
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("btnPagarTcNew", "Id");
            //Confirmar pago 
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("BtnContinuarPagoNew", "Id");

            #endregion

            //#region  Assert
            //Assert.AreEqual("Transacción rechazada", SitePages.RunEvents.FindTextElement("DxReintentoPago_lblTituloReintentoPago", "Id"));
            //#endregion
        }


        [TestMethod]
        public void B2C_Cancel_Retry_Payment_Case_1_Espanol()
        {
            #region Arrange
            string url = "http://localhost/B2C/";
            string PageTitle = "Avianca";

            Browser.setDriver = @"C:\WebDrivers\chromedriver\2.3";
            SitePages.RunEvents.TimeOut = 30;

            SitePages.RunEvents.GoTo(url);
            Assert.IsTrue(SitePages.RunEvents.IsAt(PageTitle));
            string ScreenShotPath = @"C:\Evidencias\B2C\";
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
            SitePages.RunEvents.LoaStandby(10000);
            SitePages.RunEvents.SwitchToFrame("FrameAmadeus,Id");

            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            SitePages.RunEvents.EnterElement("w63", "Id");

            //llenar datos del viajero
            SitePages.RunEvents.SwitchToFrame("FrameAmadeus,Id");
            SitePages.RunEvents.TextToElement("txtApellidoViajero", "Id", "prueba");
            SitePages.RunEvents.TextToElement("txtNombreViajero", "Id", "prueba");
            SitePages.RunEvents.TextToElement("txtMailViajero", "Id", "preuba@prueba1.com");
            SitePages.RunEvents.TextToElement("txtTelefonoViajero", "Id", "1234567");
            SitePages.RunEvents.ClickElement("chkPoliticas", "Id");

            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            SitePages.RunEvents.ClickElement("btnContinuar", "Id");

            //Complementar datos del viajero 
            SitePages.RunEvents.SwitchToFrame("FrameAmadeus,Id");
            SitePages.RunEvents.TextToElement("tpl3_widget-input-travellerList-traveller_0_ADT-IDEN_DateOfBirth-DateDay", "Id", "25");
            SitePages.RunEvents.SelectListElementByValue("tpl3_widget-input-travellerList-traveller_0_ADT-IDEN_DateOfBirth-DateMonth", "Id", "12");
            SitePages.RunEvents.TextToElement("tpl3_widget-input-travellerList-traveller_0_ADT-IDEN_DateOfBirth-DateYear", "Id", "1988");

            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            SitePages.RunEvents.EnterElement("w33", "Id");

            //Confirmacion del viaje
            SitePages.RunEvents.SwitchToFrame("FrameAmadeus,Id");

            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            SitePages.RunEvents.EnterElement("w35", "Id");

            //Terminos y condiciones
            SitePages.RunEvents.SwitchToFrame("FrameAmadeus,Id");
            SitePages.RunEvents.ClickElement("w12_widget-input-purchaseForm-termsConditionsForm-termsAndCondition", "Id");
            SitePages.RunEvents.ClickElement("w12_widget-input-purchaseForm-termsConditionsForm-additionalTermsAndCondition", "Id");

            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);

            SitePages.RunEvents.EnterElement("w32", "Id");

            //Datos medio de pago 
            SitePages.RunEvents.TextToElement("DxRvlDatosTarjetaHabienteCredito_txtApellido", "Id", "prueba");
            SitePages.RunEvents.TextToElement("DxRvlDatosTarjetaHabienteCredito_txtNombreCompleto", "Id", "prueba");
            SitePages.RunEvents.SelectListElementByValue("DxRvlDatosTarjetaHabienteCredito_ddlTipoDocId", "Id", "2");
            SitePages.RunEvents.TextToElement("DxRvlDatosTarjetaHabienteCredito_txtNumIdentificacion", "Id", "1234567890");
            SitePages.RunEvents.TextToElement("DxRvlDatosTarjetaHabienteCredito_txtEmail", "Id", "prueba@prueba.com");
            SitePages.RunEvents.TextToElement("DxRvlDatosTarjetaHabienteCredito_txtTelefono", "Id", "1234567");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetasCredito_ddlTipoTarjeta", "Id", "1");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtNumeroTarjeta", "Id", "4111111111111111");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetasCredito_ddlMes", "Id", "12");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetasCredito_ddlAnio", "Id", "2019");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_TxtBxBanco", "Id", "bancolombia");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtCVV_CSS", "Id", "123");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtDireccion", "Id", "carrera");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtDireccion2", "Id", "carrera 2");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtTelefono", "Id", "1234567");
            SitePages.RunEvents.SelectListElementByValue("RVLTarjetasCredito_ddlPais", "Id", "ES");
            SitePages.RunEvents.LoaStandby(2000);
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_TxtCiudad", "Id", "medellin");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtEstado", "Id", "medellin");
            SitePages.RunEvents.TextToElement("RVLTarjetasCredito_txtCodigoZip", "Id", "12345");

            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("btnPagarTcNew", "Id");

            //Confirmar pago 
            SitePages.RunEvents.TakeScreenShot(ScreenShotPath);
            SitePages.RunEvents.ClickElement("BtnContinuarPagoNew", "Id");

            SitePages.RunEvents.LoaStandby(40000);
            SitePages.RunEvents.SwitchToFrame("FrameAmadeus,Id");
            SitePages.RunEvents.ClickElement("btnCancelar", "Id");

            SitePages.RunEvents.LoaStandby(4000);
            Assert.AreEqual("Su solicitud de compra ha sido rechazada.",
                SitePages.RunEvents.FindTextElement("lblMensajeErrorTc", "Id"));

            #endregion

            //#region  Assert
            //Assert.AreEqual("Transacción rechazada", SitePages.RunEvents.FindTextElement("DxReintentoPago_lblTituloReintentoPago", "Id"));
            //#endregion
        }
    }
}
