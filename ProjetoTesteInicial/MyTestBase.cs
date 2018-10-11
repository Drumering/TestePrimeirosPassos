using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteInicial
{
    [TestClass]
    public class MyTestBase
    {
        private static IWebDriver driver;

        public void GoToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }

        public static By Imagens()
        {
            return By.PartialLinkText("Imagens");
        }

        public static By BuscarImagens()
        {
            return By.Id("lst-ib");
        }

        [TestInitialize]
        public void MinhaInicializacao()
        {
            driver = new ChromeDriver(Path.Combine(AppDomain.CurrentDomain.BaseDirectory));
        }
        
        [TestMethod]
        public void PrimeiroTeste()
        {
            string url = "https://www.google.com.br";
            GoToUrl(url);

            driver.FindElement(Imagens()).Click();
            driver.FindElement(BuscarImagens()).SendKeys("teste" + Keys.Return);
        }
    }
}
