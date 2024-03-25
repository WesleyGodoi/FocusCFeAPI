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
            cfe.DadosCfe.Destinatario.NomeDestinatario = "teste";
            cfe.DadosCfe.Destinatario.CpfDestinatario = "73555764020";
            cfe.DadosCfe.Itens.Add(new ItemModel()
            {
                CodigoNcm = "21069090",
                CodigoProduto = "A01",
                Descricao = "prod01",
                Quantidade = 1,
                Cfop = "5102",
                ValorUnitario = 10,
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
    }
}
