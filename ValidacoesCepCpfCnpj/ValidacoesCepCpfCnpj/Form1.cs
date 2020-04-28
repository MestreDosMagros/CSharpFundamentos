using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidacoesCepCpfCnpj
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _client;
        private const string _url = @"https://viacep.com.br/ws/{cep}/json/";

        public Form1()
        {
            InitializeComponent();
            _client = new HttpClient();
        }

        private void btnValidarCep_Click(object sender, EventArgs e)
        {
            var cepDigitado = txtCep.Text.Replace("-", "").Trim();

            txtCep.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtLocalidade.Text = string.Empty;
            txtUF.Text = string.Empty;
            lblErro.Visible = false;

            if (cepDigitado.Length != 8)
            {
                MessageBox.Show("Cep deve ter 8 dígitos");
                return;
            }

            var infoCep = BuscaCep(cepDigitado);

            if (string.IsNullOrEmpty(infoCep.Cep))
            {
                lblErro.Visible = true;
                return;
            }

            txtCep.Text = infoCep.Cep;
            txtLogradouro.Text = infoCep.Logradouro;
            txtComplemento.Text = infoCep.Complemento;
            txtBairro.Text = infoCep.Bairro;
            txtLocalidade.Text = infoCep.Localidade;
            txtUF.Text = infoCep.UF;
            lblErro.Visible = false;
        }

        private InfoEndereco BuscaCep(string cep)
        {
            InfoEndereco retorno = null;
            try
            {
                var result = _client.GetAsync(_url.Replace("{cep}", cep)).GetAwaiter().GetResult();

                if (result.IsSuccessStatusCode)
                {
                    var content = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    retorno = JsonConvert.DeserializeObject<InfoEndereco>(content);
                }
                else
                    throw new Exception("Cep inválido");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }

            return retorno;
        }
    }

    public class InfoEndereco
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public int? IBGE { get; set; }
        public int? Gia { get; set; }
    }
}
