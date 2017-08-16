using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeRates
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string UsdCourse()
        {
            System.Net.WebClient wbc = new System.Net.WebClient();
            String Response = wbc.DownloadString("http://kazfin.info/exchange/astana/usd");
            String usdRateBuy = System.Text.RegularExpressions.Regex.Match(Response, @"data-buy=""([0-9]+\.[0-9]+)").Groups[1].Value;
            String usdRateSale = System.Text.RegularExpressions.Regex.Match(Response, @"data-sale=""([0-9]+\.[0-9]+)").Groups[1].Value;
            return "Текущий курс обмена валюты составляет: " + usdRateBuy + "/" + usdRateSale + " тенге.";
        }

        private string EurCourse()
        {
            System.Net.WebClient wbc = new System.Net.WebClient();
            String Response = wbc.DownloadString("http://kazfin.info/exchange/astana/eur");
            String eurRateBuy = System.Text.RegularExpressions.Regex.Match(Response, @"data-buy=""([0-9]+\.[0-9]+)").Groups[1].Value;
            String eurRateSale = System.Text.RegularExpressions.Regex.Match(Response, @"data-sale=""([0-9]+\.[0-9]+)").Groups[1].Value;
            return "Текущий курс обмена валюты составляет: " + eurRateBuy + "/" + eurRateSale + " тенге.";
        }

        private string RubCourse()
        {
            System.Net.WebClient wbc = new System.Net.WebClient();
            String Response = wbc.DownloadString("http://kazfin.info/exchange/astana/rur");
            String rubRateBuy = System.Text.RegularExpressions.Regex.Match(Response, @"data-buy=""([0-9]+\.[0-9]+)").Groups[1].Value;
            String rubRateSale = System.Text.RegularExpressions.Regex.Match(Response, @"data-sale=""([0-9]+\.[0-9]+)").Groups[1].Value;
            return "Текущий курс обмена валюты составляет: " + rubRateBuy+ "/" + rubRateSale + " тенге.";

        }

       

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBox.Text = UsdCourse();
        }

        private void buttonEUR_Click(object sender, EventArgs e)
        {
            textBox.Text = EurCourse();
        }

        private void buttonRUB_Click(object sender, EventArgs e)
        {
            textBox.Text = RubCourse();
        }

        private void buttonUSD_Click(object sender, EventArgs e)
        {
            textBox.Text = UsdCourse();
        }
    }
}
