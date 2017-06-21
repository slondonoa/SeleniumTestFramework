using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumFramework.Common;
using System;
using System.Threading;

namespace SeleniumFramework.ExecutionSteps
{
    public class RunEvents
    {
        /// <summary>
        /// Metodo usuado para dirigice a una url especifica 
        /// </summary>
        /// <param name="url">url a donde quiere realizar la redireccion</param>
        public void GoTo(string url)
        {
            Browser.Goto(url);
        }

        private int timeout = 30;

        public int TimeOut
        {
            set
            {
                timeout = value;
            }
        }

        /// <summary>
        /// metodo para verificar por medio del titulo si estamos en la pagina correcta
        /// </summary>
        /// <param name="PageTitle">titulo de la pagia</param>
        /// <returns></returns>
        public bool IsAt(string PageTitle)
        {
            return Browser.Title == PageTitle;
        }

        public string GetTitle()
        {
            return Browser.Title;
        }

        /// <summary>
        /// Metodo usado para seleccionar un elemento de una lista por medio del valor de texto
        /// </summary>
        /// <param name="element">Nombre del elemento</param>
        /// <param name="findBy">Buscar por</param>
        /// <param name="select">Texto a seleccionar</param>
        public void SelectListElementByText(string element, string findBy, string select)
        {
            var driver = Browser.Driver;
            IWebElement webelement;
            var by = Browser.ElementBy(findBy, element);
            webelement = FindElement(by, timeout);
            new SelectElement(webelement).SelectByText(select);
        }

        /// <summary>
        /// Metodo usado para seleccionar un elemento de una lista por medio de su valor
        /// </summary>
        /// <param name="element">Nombre del elemento</param>
        /// <param name="findBy">Buscar por</param>
        /// <param name="select">Valor a seleccionar</param>
        public void SelectListElementByValue(string element, string findBy, string select)
        {
            var driver = Browser.Driver;
            IWebElement webelement;
            var by = Browser.ElementBy(findBy, element);
            webelement = FindElement(by, timeout);
            new SelectElement(webelement).SelectByValue(select);
        }

        /// <summary>
        /// insertar texto en un elemento
        /// </summary>
        /// <param name="element">Nombre del elemento</param>
        /// <param name="findBy">Buscar por</param>
        /// <param name="text">Texto</param>
        public void TextToElement(string element, string findBy, string text)
        {
            var driver = Browser.Driver;
            IWebElement webelement;
            var by = Browser.ElementBy(findBy, element);
            webelement = FindElement(by, timeout);
            webelement.Clear();
            webelement.SendKeys(text);
        }

        /// <summary>
        /// Metodo utlizado para hacer un evento click 
        /// </summary>
        /// <param name="element">nombre del elemento</param>
        /// <param name="findBy">buscar por</param>
        public void ClickElement(string element, string findBy)
        {

            var driver = Browser.Driver;
            IWebElement webelement;
            var by = Browser.ElementBy(findBy, element);
            webelement = FindElement(by, timeout);
            webelement.Click();
        }

        /// <summary>
        /// Metodo utlizado para hacer un evento submit 
        /// </summary>
        /// <param name="element">nombre del elemento</param>
        /// <param name="findBy">buscar por</param>
        public void SubmitElement(string element, string findBy)
        {

            var driver = Browser.Driver;
            IWebElement webelement;
            var by = Browser.ElementBy(findBy, element);
            webelement = FindElement(by, timeout);
            webelement.Submit();
        }


        /// <summary>
        /// Metodo utlizado para hacer un evento Enter 
        /// </summary>
        /// <param name="element">nombre del elemento</param>
        /// <param name="findBy">buscar por</param>
        public void EnterElement(string element, string findBy)
        {

            var driver = Browser.Driver;
            IWebElement webelement;
            var by = Browser.ElementBy(findBy, element);
            webelement = FindElement(by, timeout);
            webelement.SendKeys(Keys.Enter);
        }

        /// <summary>
        /// Metodo usuaro para cargar un frame de una pagina 
        /// </summary>
        /// <param name="frames">en este parametro se debe enciar nombreframe,y identificador por el que se desea buscar y se son anidados separados por |
        /// ejemplo fram1,Id|frame2,Name</param>
        public void SwitchToFrame(string frames)
        {
            Browser.switchToFrame(frames);
        }

        /// <summary>
        /// buscar un elemento dentro de la pagina 
        /// </summary>
        /// <param name="by">Por que identificador los vamos a bucar</param>
        /// <param name="timeoutInSeconds">el tiempo de espera para buscar el elemento</param>
        /// <returns></returns>
        public static IWebElement FindElement(By by, int timeoutInSeconds)
        {
            return Browser.FindElement(by, timeoutInSeconds);
        }


        /// <summary>
        /// buscar texto de un elemento dentro de la pagina 
        /// </summary>
        /// <param name="by">Por que identificador los vamos a bucar</param>
        /// <param name="timeoutInSeconds">el tiempo de espera para buscar el elemento</param>
        /// <returns></returns>
        public string FindTextElement(string element, string findBy)
        {
            var by = Browser.ElementBy(findBy, element);
            var elementText = Browser.FindElement(by, timeout);
            return elementText.Text;
        }

        /// <summary>
        /// Metodo para realizar una espera mientra se carga un evento en el formulario
        /// </summary>
        /// <param name="milliseconds">tiempo en milisegundos</param>
        public void LoaStandby(int milliseconds)
        {
            Thread.Sleep(milliseconds);
        }

        public void TakeScreenShot(string pathToFolder)
        {
            Browser.TakeScreenShot(pathToFolder);

        }

        public bool ElementPresent(string element, string findBy)
        {
            try
            {
                var driver = Browser.Driver;
                IWebElement webelement;
                var by = Browser.ElementBy(findBy, element);
                webelement = FindElement(by, timeout);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}
