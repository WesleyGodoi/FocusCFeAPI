using System.Text.Json.Serialization;

namespace FocusCFeMFeApi.Models
{
    public class DadosDestinatarioModel
    {
        [JsonPropertyName("nome_destinatario")]
        public string NomeDestinatario { get; set; }

        [JsonPropertyName("cnpj_destinatario")]
        public string CnpjDestinatario { get; set; }

        [JsonPropertyName("cpf_destinatario")]
        public string CpfDestinatario { get; set; }
    }
}
