using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumFramework.Common
{
    public static class Browser
    {

        //static IWebDriver webDriver = new ChromeDriver(@"C:\WebDrivers\chromedriver\chromedriver_win32");
        static IWebDriver webDriver;

        /// <summary>
        /// Metodo usado para obtener el titulo de la pagina 
        /// </summary>
        public static string Title
        {
            get { return webDriver.Title; }
        }

        /// <summary>
        /// medoto que nos devuelve la instacia del webdriver cargado 
        /// </summary>
        public static ISearchContext Driver
        {
            get
            {
                return webDriver;
            }
        }

        public static string setDriver
        {
            set
            {
                webDriver = new ChromeDriver(value);
            }
        }

        /// <summary>
        /// metodo usado ir a una url 
        /// </summary>
        /// <param name="url">url que desamos cargar</param>
        public static void Goto(string url)
        {
            webDriver.Url = url;
        }

        /// <summary>
        /// buscar un elemento dentro de la pagina 
        /// </summary>
        /// <param name="by">Por que identificador los vamos a bucar</param>
        /// <param name="timeoutInSeconds">el tiempo de espera para buscar el elemento</param>
        /// <returns></returns>
        public static IWebElement FindElement(By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {

                var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return webDriver.FindElement(by);
        }

        /// <summary>
        /// Metodo usuaro para cargar un frame de una pagina 
        /// </summary>
        /// <param name="frames">en este parametro se debe enciar nombreframe,y identificador por el que se desea buscar y se son anidados separados por |
        /// ejemplo fram1,Id|frame2,Name</param>
        public static void switchToFrame(string frames)
        {
            string currentWindow = webDriver.CurrentWindowHandle;
            webDriver.SwitchTo().Window(currentWindow);
            var framesSplitFrames = frames.Split('|');
            foreach (var frame in framesSplitFrames)
            {
                var framesBy = frame.Split(',');
                var by = ElementBy(framesBy[1], framesBy[0]);

                WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(by));

                //webDriver.SwitchTo().Frame(webDriver.FindElement(by));
            }
        }

        /// <summary>
        /// Metodo utlizado para poder obetner los elementos de la confirmaciond e vuelos 
        /// de amadeus 
        /// </summary>
        /// <param name="frameAmadeusCoporativo">Frame que se carga en la pagina Corporativo.aspx</param>
        /// <param name="frameAmadeusDefault">Franme donde se carga amadeus en la pagina Default.aspx</param>
        public static void switchToAmadeusFrame(string frameAmadeusCoporativo, string frameAmadeusDefault)
        {
            string currentWindow = webDriver.CurrentWindowHandle;
            //switch to frame and do stuff..
            webDriver.SwitchTo().Window(currentWindow);
            webDriver.SwitchTo().Frame(webDriver.FindElement(By.Name(frameAmadeusCoporativo)));
            var elementAmadeus = webDriver.FindElement(By.Id(frameAmadeusDefault));
            webDriver.SwitchTo().Frame(elementAmadeus);

        }
        /// <summary>
        /// Buscasr un elemento en la pagina
        /// </summary>
        /// <param name="findBy">por cual identificador de desea bucar Id,Name,ClassName,CssSelector,XPath</param>
        /// <param name="element"></param>
        /// <returns></returns>
        public static By ElementBy(string findBy, string element)
        {
            By by;
            switch (findBy)
            {
                case "Id":
                    by = By.Id(element);
                    break;
                case "Name":
                    by = By.Name(element);
                    break;
                case "ClassName":
                    by = By.ClassName(element);
                    break;
                case "CssSelector":
                    by = By.CssSelector(element);
                    break;
                case "XPath":
                    by = By.XPath(element);
                    break;
                case "LinkText":
                    by = By.LinkText(element);
                    break;
                default:
                    by = By.Name(element);
                    break;

            }

            return by;
        }

        public static void TakeScreenShot(string PathToFolder)
        {
            string fileName = PathToFolder + DateTime.Now.ToString("HHmmss") + ".jpeg";
            Screenshot cp = ((ITakesScreenshot)webDriver).GetScreenshot();
            cp.SaveAsFile(fileName, ScreenshotImageFormat.Jpeg);

        }

    }
}
