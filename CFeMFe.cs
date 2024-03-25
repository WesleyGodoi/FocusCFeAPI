using FocusCFeMFeApi.Dtos;
using FocusCFeMFeApi.Interfaces;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using FocusCFeMFeApi.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace FocusCFeMFeApi
{
    public class CFeMFe : ICFeMFe 
    {
        public CFeModel DadosCfe { get; set; }

        public CFeMFe()
        {
            DadosCfe = new CFeModel
            {
                Itens = new List<ItemModel>(),
                Destinatario = new DadosDestinatarioModel(),
                FormasPagamento = new List<FormaPagamentoModel>()
            };
        }

        public async void EmitirCFe(CFeModel cfeMfe)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri($"http://localhost:5555/v2/fiscal/sat?ref={cfeMfe.Id}");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

        public void CancelarCFe(CFeModel cfeMfe)
        {
            throw new NotImplementedException();
        }

        public void ConsultarCFe(CFeModel cfeMfe)
        {
            throw new NotImplementedException();
        }

        public void ConsultarStatusMFe(CFeModel cfeMfe)
        {
            throw new NotImplementedException();
        }
        
    }
        
    
}
