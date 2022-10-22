using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteAutomacao;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TesteAutomacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private EdgeDriver drv
        {
            get; set;
        }
        private ListBox log
        {
            get; set;
        }

        private void ExibirLog(string mensagem)
        {
            string h = DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString();
            string m = DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString();
            string s = DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString();

            string horaformatada = String.Format("{0}:{1}:{2}", h, m, s);

            txtLog.Invoke((MethodInvoker)delegate
            {
                txtLog.Items.Add(DateTime.Now.ToShortDateString() + " " + horaformatada + ": " + mensagem);
                txtLog.Refresh();
            });
        }
        private EdgeDriver OpenDriver()
        {
            var drvService = EdgeDriverService.CreateDefaultService();
            drvService.HideCommandPromptWindow = true;
            EdgeOptions options = new EdgeOptions();
            //drv = new EdgeDriver(drvService, options);
            //options.BinaryLocation = Directory.GetCurrentDirectory() + @"\msedgedriver.exe";
            if (exibir_navegador.Checked)
                options.AddArguments("headless");
            drv = new EdgeDriver(drvService, options);
            drv.Goto("https://www.dafabet.com/pt/dfgoal/sports");
            return drv;
        }

        private void txtLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExibirResultado_Click(object sender, EventArgs e)
        {
            try
            {
                OpenDriver();
                abrirJogo();
                encontrarDados();
            }
            catch (Exception)
            {
                excecao();
            }
        }
        private void abrirJogo()
        {
            drv.Manage().Window.Maximize();
            ExibirLog("Início da pesquisa das apostas.");
           
            OpenQA.Selenium.Support.UI.WebDriverWait obj = new OpenQA.Selenium.Support.UI.WebDriverWait(drv, TimeSpan.FromSeconds(5));
            obj.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("758")));
            drv.FindElement(By.CssSelector(("div[class='tool-button tool-day-picker']"))).Click();
            drv.FindElement(By.CssSelector("ul[class='dwn-options daypicker-options'] li [data-selected='Futuro']")).Click();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair da aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (painel.Items.Count > 0)
            {
                Regex filter_numbers = new Regex("[^\\d]+");
                string date = Convert.ToString(DateTime.Now);
                string DateNow = filter_numbers.Replace(date, "");

                FolderBrowserDialog dig = new FolderBrowserDialog();

                dig.ShowDialog();

                string caminhoArquivo = dig.SelectedPath + $"\\arquivo{DateNow}.txt";

                using (StreamWriter arquivo = new StreamWriter(caminhoArquivo, true))
                {
                    for (int i = 0; i < painel.Items.Count; i++)
                    {
                        arquivo.WriteLine(painel.Items[i].ToString());

                    }
                }
            }
            else
            {
                MessageBox.Show("Não há dados para extrair!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCleanTxt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja limpar o histórico da aplicação?", "HISTÓRICO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                painel.Items.Clear();
        }

        private void exibir_navegador_CheckedChanged(object sender, EventArgs e)
        {
            var obj = (CheckBox)sender;
            Properties.Settings.Default.headless = obj.Checked;
            Properties.Settings.Default.Save();
        }
        private string[] elementos()
        {
            
            IWebElement tabelaCompleta = drv.FindElement(By.CssSelector("div[class='rollup event_path event_paths_container rollup-down ']"));
            string[] listaCompleta = tabelaCompleta.FindElements(By.CssSelector("div[class='event_path-content event-path-component']")).ToArray().Select(p => p.Text).ToArray();
            string[] listaInteira = tabelaCompleta.FindElements(By.CssSelector("div[class='event_path-content event-path-component row-colors-inverted']")).ToArray().Select(p => p.Text).ToArray();

            var arr3 = listaCompleta.Union(listaInteira).ToArray<string>();
            drv.ExecuteScript("document.querySelector(\"div[class='paginator']\").scrollIntoView();");
            string paginas = drv.FindElement(By.CssSelector("div[class='paginator']")).Text;
            Regex filter_numbers = new Regex("[^\\d]+");
            string page = filter_numbers.Replace(paginas, "");
            char[] chars = page.ToCharArray();
            for (int i = 1; i < chars.Length; i++)
            {
                drv.FindElement(By.CssSelector("div[class='paginator'] [class='page']")).Click();
                //elempg.FindElement(By.XPath($"//a[text()='{i}']")).Click();
            }
            if (chars.Length > 0)
            {
                foreach (var handle in drv.WindowHandles)
                {
                    drv.SwitchTo().Window(handle);
                }
                drv.SwitchTo().Window(drv.WindowHandles[0]);
                IWebElement listaInteirar = drv.FindElement(By.CssSelector("div[class='rollup event_path event_paths_container rollup-down ']"));
                string[] listaCompleta1 = listaInteirar.FindElements(By.CssSelector("div[class='event_path-content event-path-component']")).ToArray().Select(p => p.Text).ToArray();
                string[] listaInteira1 = listaInteirar.FindElements(By.CssSelector("div[class='event_path-content event-path-component row-colors-inverted']")).ToArray().Select(p => p.Text).ToArray();
                var arr4 = listaCompleta1.Union(listaInteira1).ToArray<string>();
                var arr5 = arr3.Union(arr4).ToArray<string>();
                return arr5;

            }

                return arr3;
            
            string[] lad = { "1","2" };
            return lad;
        }
        private void encontrarDados()
        {
            Thread.Sleep(3000);
           
            string[] elemento = elementos();

            painel.View = View.Details;
            painel.LabelEdit = true;
            painel.AllowColumnReorder = true;
            painel.FullRowSelect = true;
            painel.GridLines = true;

            ListViewItem item = new ListViewItem(elemento[1]);
            int n = 300; // contar ou interromper o loop

            string[] arr = new string[n];
            int b;
            string aLine = null;
            /*
            painel.Columns.Add("Data", 150, HorizontalAlignment.Left);
            painel.Columns.Add("Hora", 70, HorizontalAlignment.Left);
            painel.Columns.Add("Time", 120, HorizontalAlignment.Left);
            painel.Columns.Add("1", 50, HorizontalAlignment.Left);
            painel.Columns.Add("X", 50, HorizontalAlignment.Left);
            painel.Columns.Add("2", 50, HorizontalAlignment.Left);

             */
            for (int c = 0; c < elemento.Length; c++)
            {
                StringReader strReader = new StringReader(elemento[c]);

                for (b = 0; b < n; b++)
                {
                    aLine = strReader.ReadLine();
                    if (aLine != null)
                    {
                        arr[b] = aLine;
                    }
                    else
                    {
                        break;
                    }
                }
                ListViewItem campeo = new ListViewItem(arr[0]);
                painel.Items.Add(campeo);


                int pos = 1;
                for (b = 2; b < n; b++)
                {
                    if (arr[b] != null)
                    {
                        string[] linha = { arr[b], arr[b + 1], arr[b + 2], arr[b + 3], arr[b + 4], arr[b + 5] };
                        ListViewItem odds = new ListViewItem(linha);
                        painel.Items.Add(odds);

                        b = b + 6;
                        pos = pos + 1;
                    }
                    else
                        break;
                }
            }
          
        }
        private void excecao()
        {
            ExibirLog("Reiniciando o processo...");
            drv.Goto("https://www.dafabet.com/pt/dfgoal/sports");
            abrirJogo();
            encontrarDados();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
