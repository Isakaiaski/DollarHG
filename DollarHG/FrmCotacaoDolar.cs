using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarHG
{
    public partial class FrmCotacaoDolar : MetroFramework.Forms.MetroForm
    {
        public FrmCotacaoDolar()
        {
            InitializeComponent();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strURL = "https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,USD&key=264f6144";

            using (HttpClient Client = new HttpClient())
            {
                try
                {
                    var response = Client.GetAsync(strURL).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;

                        Market market = JsonConvert.DeserializeObject<Market>(result);

                        lblMstBuy.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Buy);
                        lblMstSell.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Sell);
                        lblMstVariation.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:P}", market.Currency.Variation / 100);

                    }
                    else
                    {
                        lblMstBuy.Text = "-";
                        lblMstSell.Text = "-";
                        lblMstVariation.Text = "-";
                    }
                }
                catch (Exception ex)
                {
                    lblMstBuy.Text = "-";
                    lblMstSell.Text = "-";
                    lblMstVariation.Text = "-";
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
