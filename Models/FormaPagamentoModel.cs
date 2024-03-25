using System.Text.Json.Serialization;

namespace FocusCFeMFeApi.Models
{
    public class FormaPagamentoModel
    {
        [JsonPropertyName("forma_pagamento")]
        public string FormaPagamento { get; set; }

        [JsonPropertyName("valor_pagamento")]
        public string ValorPagamento { get; set; }

        [JsonPropertyName("nome_credenciadora")]
        public string NomeCredenciadora { get; set; }
    }
}
