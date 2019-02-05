using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace UnitTestProject1.Base
{
    public static class Driver
    {
        private static WebDriverWait _BrowserWait;

        private static IWebDriver _Browser;

        public static IWebDriver Browser
        {
            get
            {
                if (_Browser == null)
                {
                    throw new NullReferenceException("Browser neinitializat");
                }
                return _Browser;
            }
            private set
            {
                _Browser = value;
            }
        }

        public static WebDriverWait BrowserWait
        {
            get
            {
                if (_BrowserWait == null || _Browser == null)
                {
                    throw new NullReferenceException("Browser neinitializat.");
                }
                return _BrowserWait;
            }
            private set
            {
                _BrowserWait = value;
            }
        }

        public static void StartBrowser(TipBrowser BrowserInUse, int InitializationTimeout)
        {
            switch (BrowserInUse)
            {
                case TipBrowser.Firefox:
                    Browser = new FirefoxDriver();
                    break;
                case TipBrowser.Chrome:
                    Browser = new ChromeDriver();
                    break;
                default:
                    break;
            }
            BrowserWait = new WebDriverWait(Browser, TimeSpan.FromSeconds(InitializationTimeout));
        }

        public static void StopBrowser()
        {
            Browser.Quit();
            Browser = null;
            BrowserWait = null;
        }
    }
}
