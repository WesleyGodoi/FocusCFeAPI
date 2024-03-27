using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using JsonIgnoreAttribute = Newtonsoft.Json.JsonIgnoreAttribute;

namespace FocusCFeMFeApi.Models
{
    public class CFeModel
    {
        [JsonIgnore]
        public int Id { get; set; }

        [JsonProperty("nome_emitente")]
        public string NomeEmitente { get; set; }

        [JsonProperty("natureza_operacao")]
        public string NaturezaOperacao { get; set; }

        [JsonProperty("data_emissao")]
        public DateTime? DataEmissao { get;}

        [JsonProperty("presenca_comprador")]
        public int PresencaComprador { get; set; }

        [JsonProperty("modalidade_frete")]
        public int ModalidadeFrete {  get; set; }

        [JsonProperty("local_destino")]
        public int LocalDestino {  get; set; }

        [JsonProperty("cnpj_emitente")]
        public string CnpjEmitente { get; set; }

        [JsonProperty("telefone_emitente")]
        public string TelefoneEmitente { get; set; }

        [JsonProperty("municipio_emitente")]
        public string MunicipioEmitente { get; set; }

        [JsonProperty("logadouro_emitente")]
        public string LogadouroEmitente {  get; set; }

        [JsonProperty("numero_emitente")]
        public string NumeroEmitente { get; set; }

        [JsonProperty("bairro_emitente")]
        public string BairroEmitente {  get; set; }

        [JsonProperty("cep_emitente")]
        public string CepEmitente { get; set; }

        [JsonProperty("uf_emitente")]
        public string UfEmitente { get; set; }  

        [JsonProperty("valor_total")]
        public string ValorTotal {  get; set; }

        [JsonProperty("nome_destinatario")]
        public string NomeDestinatario { get; set; }

        [JsonProperty("cnpj_destinatario")]
        public string CnpjDestinatario { get; set; }

        [JsonProperty("cpf_destinatario")]
        public string CpfDestinatario { get; set; }        

        [JsonProperty("items")]
        public  List<ItemModel> Itens { get; set; } = new List<ItemModel>();

        [JsonProperty("formas_pagamento")]
        public List<FormaPagamentoModel> FormasPagamento { get; set; } = new List<FormaPagamentoModel>();       

    }
}
