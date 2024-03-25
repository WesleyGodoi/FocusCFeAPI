using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FocusCFeMFeApi.Models
{
    public class CFeModel
    {
        public int Id { get; set; }

        [JsonPropertyName("items")]
        public  List<ItemModel> Itens { get; set; }

        public  DadosDestinatarioModel Destinatario { get; set; }

        [JsonPropertyName("formas_pagamento")]
        public  List<FormaPagamentoModel> FormasPagamento { get; set;}        

    }
}
