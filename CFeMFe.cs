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
using RestSharp;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace FocusCFeMFeApi
{
    public class CFeMFe : ICFeMFe 
    {
        public CFeModel DadosCfe { get; set; } = new CFeModel();

        public void EmitirCFe(CFeModel cfeMfe)
        {
            var client = new RestClient($"http://localhost:5555/v2/fiscal/sat?ref={cfeMfe.Id}");
            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddJsonBody(JsonConvert.SerializeObject(cfeMfe));

            try
            {
                var response = client.Execute(request);

                if (response.ResponseStatus == ResponseStatus.Completed)
                {
                    //Deserializa o objeto recebido utilizando a classe que se espera receber
                    var dadosEsperados = JsonConvert.DeserializeObject<ResponseGenericos>(response.Content);
                }
                else
                {
                    throw new Exception("Falha no Request");
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Erro durante o processo de envio do CFe nº{0}. ", cfeMfe.Id.ToString(), e.Message);
            }
        }

        public static void CancelarCFe(int idCfeMfe, string justificativa)
        {
            var client = new RestClient($"http://localhost:5555/v2/fiscal/sat?ref={idCfeMfe}");
            var request = new RestRequest
            {
                Method = Method.Delete
            };
            JsonSerializerSettings serializerSettings = new JsonSerializerSettings();
            request.AddJsonBody(JsonConvert.SerializeObject("justificativa: " + justificativa));

            try
            {
                var response = client.Execute(request);

                if (response.ResponseStatus == ResponseStatus.Completed)
                {
                    //Deserializa o objeto recebido utilizando a classe que se espera receber
                    var dadosEsperados = JsonConvert.DeserializeObject<ResponseGenericos>(response.Content);
                }
                else
                {
                    throw new Exception("Falha no Request");
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Erro durante o processo de cancelamento do CFe nº{0}. ", idCfeMfe.ToString(), e.Message);
            }
        }

        public static void ConsultarCFe(int idCfeMfe)
        {
            var client = new RestClient($"http://localhost:5555/v2/fiscal/sat/cfe/{idCfeMfe}");
            var request = new RestRequest
            {
                Method = Method.Get
            };

            try
            {
                var response = client.Execute(request);

                if (response.ResponseStatus == ResponseStatus.Completed)
                {
                    //Deserializa o objeto recebido utilizando a classe que se espera receber
                    var dadosEsperados = JsonConvert.DeserializeObject<ResponseGenericos>(response.Content);
                }
                else
                {
                    throw new Exception("Falha no Request");
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Erro durante o processo de consulta do CFe nº{0}. ", idCfeMfe.ToString(), e.Message);
            }
        }

        public void ConsultarStatusMFe()
        {
            var client = new RestClient("http://localhost:PORTA/v2/fiscal/sat/status");
            var request = new RestRequest
            {
                Method = Method.Get
            };

            try
            {
                var response = client.Execute(request);

                if (response.ResponseStatus == ResponseStatus.Completed)
                {
                    //Deserializa o objeto recebido utilizando a classe que se espera receber
                    var dadosEsperados = JsonConvert.DeserializeObject<ResponseGenericos>(response.Content);
                }
                else
                {
                    throw new Exception("Falha no Request");
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Erro durante o processo de consulta de status. ", e.Message);
            }
        }
        
    }
        
    
}
