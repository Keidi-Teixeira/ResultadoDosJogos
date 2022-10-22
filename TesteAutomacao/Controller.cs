using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteAutomacao
{
    static class Controller
    {
        private static EdgeDriver drv
        {
            get; set;
        }
        private static ListBox log
        {
            get; set;
        }
        private static void ExibirLog(string mensagem)
        {
            log.Invoke((System.Windows.Forms.MethodInvoker)delegate
            {
                log.Items.Add(DateTime.Now + ": " + mensagem);
                log.Refresh();
            });
        }
        public static EdgeDriver Goto(this EdgeDriver drv, string url)
        {
            try
            {
                drv.Navigate().GoToUrl(url);
            }
            catch (WebDriverException ex)
            {
                string erro1 = drv.FindElement(By.Id("main-message")).Text;
                ExibirLog(erro1);
            }
            return drv;
        }

    }
}
