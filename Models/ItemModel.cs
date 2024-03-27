using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace FocusCFeMFeApi.Models
{
    public class ItemModel
    {
        [JsonProperty("numero_item")]
        public int NumeroItem { get; set; }

        [JsonProperty("codigo_ncm")]
        public string CodigoNcm { get; set; }

        [JsonProperty("codigo_produto")]
        public string CodigoProduto { get; set; }

        [JsonProperty("descricao")]
        public string Descricao { get; set; }

        [JsonProperty("quantidade_comercial")]
        public int QuantidadeComercial { get; set; }

        [JsonProperty("quantidade_tributavel")]
        public int QuantidadeTributavel { get; set; }

        [JsonProperty("cfop")]
        public string Cfop { get; set; }

        [JsonProperty("valor_unitario_comercial")]
        public double ValorUnitarioComercial { get; set; }

        [JsonProperty("valor_unitario_tributavel")]
        public double ValorUnitarioTributavel { get; set; }

        [JsonProperty("valor_bruto")]
        public double ValorBruto { get; set; }

        [JsonProperty("unidade_comercial")]
        public string UnidadeComercial { get; set; }

        [JsonProperty("unidade_tributavel")]
        public string UnidadeTributavel { get; set; }

        [JsonProperty("icms_origem")]
        public string IcmsOrigem { get; set; }

        [JsonProperty("icms_situacao_tributaria")]
        public string IcmsSituacaoTributaria { get; set; }

        [JsonProperty("icms_aliquota")]
        public double AliquotaIcms { get; set; }

        [JsonProperty("icms_base_calculo")]
        public double BaseCalculoIcms {  get; set; }

        [JsonProperty("icms_modalidade_base _calculo")]
        public double ModalidadeBaseCalculoIcms { get; set; }

        [JsonProperty("valor_desconto")]
        public double ValorDesconto { get; set; }

        [JsonProperty("valor_frete")]
        public double ValorFrete {  get; set; }

        [JsonProperty("valor_outras_despesas")]
        public double ValorOutrasDespesas { get; set; }       

        [JsonProperty("pis_situacao_tributaria")]
        public string CodigoPisSituTributaria { get; set; }

        [JsonProperty("pis_aliquota_percentual")]
        public double AliquotaPis { get; set; }

        [JsonProperty("cofins_situacao_tributaria")]
        public string CodigoCofinsSituTributaria { get; set; }

        [JsonProperty("cofins_aliquota_percentual")]
        public double AliquotaCofins { get; set; }


    }
}
