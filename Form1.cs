using FocusCFeMFeApi;
using FocusCFeMFeApi.Interfaces;
using FocusCFeMFeApi.Models;
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


namespace FocusCFeAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }      

        private void EmitirCFe_Click(object sender, EventArgs e)
        {
            var cfe = new CFeMFe();
            cfe.DadosCfe.Id = 10;
            cfe.DadosCfe.NomeDestinatario = "teste";
            cfe.DadosCfe.CpfDestinatario = "73555764020";
            cfe.DadosCfe.Itens.Add(new ItemModel()
            {
                NumeroItem = 1,
                CodigoNcm = "21069090",
                CodigoProduto = "A01",
                Descricao = "prod01",
                QuantidadeComercial = 1,
                QuantidadeTributavel = 1,
                Cfop = "5102",
                ValorUnitarioComercial = 10,
                ValorBruto = 10,
                UnidadeComercial = "UN",
                IcmsSituacaoTributaria = "40"
            });
            cfe.DadosCfe.FormasPagamento.Add(new FormaPagamentoModel()
            {
                FormaPagamento = "03",
                ValorPagamento = "10",
                NomeCredenciadora = "SICREDI"
            });
            cfe.EmitirCFe(cfe.DadosCfe);
        }

        private void CancelarCFe_click(object sender, EventArgs e)
        {
            string justificativa = "Sua justificativa aqui com, no minimo, 15 caracteres";
            CFeMFe.CancelarCFe(10, justificativa);
        }

        private void ConsultarCfe_Click(object sender, EventArgs e)
        {

        }

        private void ConstultarNFeSat_Click(object sender, EventArgs e)
        {

        }
    }
}
