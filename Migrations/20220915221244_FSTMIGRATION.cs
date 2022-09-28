using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormCadastro.Migrations
{
    public partial class FSTMIGRATION : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CADASTRO",
                columns: table => new
                {
                    ID_REGISTRO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NRO_INSCRICAO = table.Column<int>(type: "int", nullable: false),
                    DATA_INSCRICAO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NOME_TIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NASC_TIT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RG_TIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF_TIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EST_CIVIL_TIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SEXO_TIT = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    NATURAL_TIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NESC_ESP_TIT = table.Column<bool>(type: "bit", nullable: true),
                    NESC_ESP_TIT_DESCRICAO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOME_MAE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ENDERECO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ENDERECO_NRO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ENDERECO_COMP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BAIRRO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MUNICIPIO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TELEFONE_RES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TELEFONE_CEL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMPRESA_TIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PROF_TIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RENDA_TIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    END_COMERCIAL_TIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NRO_COMERCIAL_TIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BAIRRO_COMERCIAL_TIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CEP_COMERCIAL_TIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MUNI_COMERCIAL_TIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NOME_CON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NASC_CON = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RG_CON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF_CON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EST_CIVIL_CON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEXO_CON = table.Column<string>(type: "nvarchar(1)", nullable: true),
                    NATURAL_CON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NESC_ESP_CON = table.Column<bool>(type: "bit", nullable: true),
                    NESC_ESP_CON_DESCRICAO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMPRESA_CON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROF_CON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RENDA_CON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    END_COMERCIAL_CON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NRO_COMERCIAL_CON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BAIRRO_COMERCIAL_CON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP_COMERCIAL_CON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MUNI_COMERCIAL_CON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP1_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP1_PAREN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP1_NASC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP1_RENDA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP2_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP2_PAREN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP2_NASC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP2_RENDA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP3_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP3_PAREN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP3_NASC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP3_RENDA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP4_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP4_PAREN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP4_NASC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP4_RENDA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP5_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP5_PAREN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP5_NASC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP5_RENDA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP6_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP6_PAREN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP6_NASC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP6_RENDA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP7_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP7_PAREN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP7_NASC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP7_RENDA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP8_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP8_PAREN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP8_NASC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP8_RENDA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP9_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP9_PAREN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP9_NASC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP9_RENDA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP10_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP10_PAREN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP10_NASC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP10_RENDA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP11_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP11_PAREN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP11_NASC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEP11_RENDA = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CADASTRO", x => x.ID_REGISTRO);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_CADASTRO");
        }
    }
}
