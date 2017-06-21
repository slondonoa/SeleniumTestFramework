using OpenQA.Selenium.Support.PageObjects;
using SeleniumFramework.ExecutionSteps;

namespace SeleniumFramework.Common
{
    public static class SitePages
    {
        /// <summary>
        /// Clase donde se encuentras los eventos a ejecutar de una pagina 
        /// </summary>
        public static RunEvents RunEvents
        {
            get
            {
                var page = new RunEvents();
                PageFactory.InitElements(Browser.Driver, page);
                return page;
            }
        }

    }
}
