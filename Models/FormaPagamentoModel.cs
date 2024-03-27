using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace FocusCFeMFeApi.Models
{
    public class FormaPagamentoModel
    {
        [JsonProperty("forma_pagamento")]
        public string FormaPagamento { get; set; }

        [JsonProperty("valor_pagamento")]
        public string ValorPagamento { get; set; }

        [JsonProperty("nome_credenciadora")]
        public string NomeCredenciadora { get; set; }
    }
}
