using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FormCadastro.Models
{
    public class TB_CADASTRO
    {
        [Key]
        public Guid ID_REGISTRO { get; set; }
        [DisplayName("Nº Inscriçao")]
        public int NRO_INSCRICAO { get; set; }
        [DisplayName("Data")]
        public DateTime DATA_INSCRICAO { get; set; }
        [DisplayName("Nome")]
        public string NOME_TIT { get; set; }
        [DisplayName("Data de Nascimento")]
        public DateTime NASC_TIT { get; set; }
        [DisplayName("RG")]
        public string RG_TIT { get; set; }
        [DisplayName("CPF")]
        public string CPF_TIT { get; set; }
        [DisplayName("Estado Civíl")]
        public string EST_CIVIL_TIT { get; set; }
        [DisplayName("Sexo")]
        public char SEXO_TIT { get; set; }
        [DisplayName("Naturalidade")]
        public string NATURAL_TIT { get; set; }
        [DisplayName("Necessidade especial?")]
        public bool NESC_ESP_TIT { get; set; }
        [DisplayName("Descreva:")]
        public string NESC_ESP_TIT_DESCRICAO { get; set; }
        [DisplayName("Nome da Mãe")]
        public string NOME_MAE { get; set; }
        [DisplayName("Endereço")]
        public string ENDERECO { get; set; }
        [DisplayName("Nro")]
        public string ENDERECO_NRO { get; set; }
        [DisplayName("Complemento")]
        public string ENDERECO_COMP { get; set; }
        [DisplayName("Bairro")]
        public string BAIRRO { get; set; }
        [DisplayName("CEP")]
        public string CEP { get; set; }
        [DisplayName("Município")]
        public string MUNICIPIO { get; set; }
        [DisplayName("Telefone Residencial")]
        public string? TELEFONE_RES { get; set; }
        [DisplayName("Telefone Celular")]
        public string TELEFONE_CEL { get; set; }
        [DisplayName("Nome da Empresa")]
        public string EMPRESA_TIT { get; set; }
        [DisplayName("Profissão")]
        public string PROF_TIT { get; set; }
        [DisplayName("Renda Familiar")]
        public string RENDA_TIT { get; set; }
        [DisplayName("Endereço Comercial")]
        public string END_COMERCIAL_TIT { get; set; }
        [DisplayName("Nro")]
        public string NRO_COMERCIAL_TIT { get; set; }
        [DisplayName("Bairro")]
        public string BAIRRO_COMERCIAL_TIT { get; set; }
        [DisplayName("CEP")]
        public string CEP_COMERCIAL_TIT { get; set; }
        [DisplayName("Município")]
        public string MUNI_COMERCIAL_TIT { get; set; }
        [DisplayName("Nome")]
        public string? NOME_CON { get; set; }
        [DisplayName("Data de Nascimento")]
        public DateTime? NASC_CON { get; set; }
        [DisplayName("RG")]
        public string? RG_CON { get; set; }
        [DisplayName("CPF")]
        public string? CPF_CON { get; set; }
        [DisplayName("Estado Civíl")]
        public string? EST_CIVIL_CON { get; set; }
        [DisplayName("Sexo")]
        public char? SEXO_CON { get; set; }
        [DisplayName("Naturalidade")]
        public string? NATURAL_CON { get; set; }
        [DisplayName("Necessidade especial?")]
        public bool? NESC_ESP_CON { get; set; }
        [DisplayName("Descreva:")]
        public string? NESC_ESP_CON_DESCRICAO { get; set; }
        [DisplayName("Nome da EmpresaN")]
        public string? EMPRESA_CON { get; set; }
        [DisplayName("Profissão")]
        public string? PROF_CON { get; set; }
        [DisplayName("Renda Familiar")]
        public string? RENDA_CON { get; set; }
        [DisplayName("Endereço Comercial")]
        public string? END_COMERCIAL_CON { get; set; }
        [DisplayName("Nro")]
        public string? NRO_COMERCIAL_CON { get; set; }
        [DisplayName("Bairro")]
        public string? BAIRRO_COMERCIAL_CON { get; set; }
        [DisplayName("CEP")]
        public string? CEP_COMERCIAL_CON { get; set; }
        [DisplayName("Município")]
        public string? MUNI_COMERCIAL_CON { get; set; }
        [DisplayName("Nome")]
        public string? DEP1_NOME { get; set; }
        [DisplayName("Parentesco")]
        public string? DEP1_PAREN { get; set; }
        [DisplayName("Data de Nascimento")]
        public string? DEP1_NASC { get; set; }
        [DisplayName("Renda")]
        public string? DEP1_RENDA { get; set; }
        [DisplayName("Nome")]
        public string? DEP2_NOME { get; set; }
        [DisplayName("Parentesco")]
        public string? DEP2_PAREN { get; set; }
        [DisplayName("Data de Nascimento")]
        public string? DEP2_NASC { get; set; }
        [DisplayName("Renda")]
        public string? DEP2_RENDA { get; set; }
        [DisplayName("Nome")]
        public string? DEP3_NOME { get; set; }
        [DisplayName("Parentesco")]
        public string? DEP3_PAREN { get; set; }
        [DisplayName("Data de Nascimento")]
        public string? DEP3_NASC { get; set; }
        [DisplayName("Renda")]
        public string? DEP3_RENDA { get; set; }
        [DisplayName("Nome")]
        public string? DEP4_NOME { get; set; }
        [DisplayName("Parentesco")]
        public string? DEP4_PAREN { get; set; }
        [DisplayName("Data de Nascimento")]
        public string? DEP4_NASC { get; set; }
        [DisplayName("Renda")]
        public string? DEP4_RENDA { get; set; }
        [DisplayName("Nome")]
        public string? DEP5_NOME { get; set; }
        [DisplayName("Parentesco")]
        public string? DEP5_PAREN { get; set; }
        [DisplayName("Data de Nascimento")]
        public string? DEP5_NASC { get; set; }
        [DisplayName("Renda")]
        public string? DEP5_RENDA { get; set; }
        [DisplayName("Nome")]
        public string? DEP6_NOME { get; set; }
        [DisplayName("Parentesco")]
        public string? DEP6_PAREN { get; set; }
        [DisplayName("Data de Nascimento")]
        public string? DEP6_NASC { get; set; }
        [DisplayName("Renda")]
        public string? DEP6_RENDA { get; set; }
        [DisplayName("Nome")]
        public string? DEP7_NOME { get; set; }
        [DisplayName("Parentesco")]
        public string? DEP7_PAREN { get; set; }
        [DisplayName("Data de Nascimento")]
        public string? DEP7_NASC { get; set; }
        [DisplayName("Renda")]
        public string? DEP7_RENDA { get; set; }
        [DisplayName("Nome")]
        public string? DEP8_NOME { get; set; }
        [DisplayName("Parentesco")]
        public string? DEP8_PAREN { get; set; }
        [DisplayName("Data de Nascimento")]
        public string? DEP8_NASC { get; set; }
        [DisplayName("Renda")]
        public string? DEP8_RENDA { get; set; }
        [DisplayName("Nome")]
        public string? DEP9_NOME { get; set; }
        [DisplayName("Parentesco")]
        public string? DEP9_PAREN { get; set; }
        [DisplayName("Data de Nascimento")]
        public string? DEP9_NASC { get; set; }
        [DisplayName("Renda")]
        public string? DEP9_RENDA { get; set; }
        [DisplayName("Nome")]
        public string? DEP10_NOME { get; set; }
        [DisplayName("Parentesco")]
        public string? DEP10_PAREN { get; set; }
        [DisplayName("Data de Nascimento")]
        public string? DEP10_NASC { get; set; }
        [DisplayName("Renda")]
        public string? DEP10_RENDA { get; set; }
        [DisplayName("Nome")]
        public string? DEP11_NOME { get; set; }
        [DisplayName("Parentesco")]
        public string? DEP11_PAREN { get; set; }
        [DisplayName("Data de Nascimento")]
        public string? DEP11_NASC { get; set; }
        [DisplayName("Renda")]
        public string? DEP11_RENDA { get; set; }
    }
}
