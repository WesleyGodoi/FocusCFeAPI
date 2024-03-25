using System.Text.Json.Serialization;

namespace FocusCFeMFeApi.Models
{
    public class ItemModel
    {
        [JsonPropertyName("codigo_ncm")]
        public string CodigoNcm { get; set; }

        [JsonPropertyName("codigo_produto")]
        public string CodigoProduto { get; set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }

        [JsonPropertyName("quantidade")]
        public int Quantidade { get; set; }

        [JsonPropertyName("cfop")]
        public string Cfop { get; set; }

        [JsonPropertyName("valor_unitario")]
        public double ValorUnitario { get; set; }

        [JsonPropertyName("valor_bruto")]
        public double ValorBruto { get; set; }

        [JsonPropertyName("unidade_comercial")]
        public string UnidadeComercial { get; set; }

        [JsonPropertyName("icms_situacao_tributaria")]
        public string IcmsSituacaoTributaria { get; set; }

        [JsonPropertyName("valor_desconto")]
        public double ValorDesconto { get; set; }

        [JsonPropertyName("valor_outras_despesas")]
        public double ValorOutrasDespesas { get; set; }

        [JsonPropertyName("icms_aliquota")]
        public double AliquotaIcms { get; set; }

        [JsonPropertyName("pis_situacao_tributaria")]
        public string CodigoPisSituTributaria { get; set; }

        [JsonPropertyName("pis_aliquota_percentual")]
        public double AliquotaPis { get; set; }

        [JsonPropertyName("cofins_situacao_tributaria")]
        public string CodigoCofinsSituTributaria { get; set; }

        [JsonPropertyName("cofins_aliquota_percentual")]
        public double AliquotaCofins { get; set; }


    }
}
