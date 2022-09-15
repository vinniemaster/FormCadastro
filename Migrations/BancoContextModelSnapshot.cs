﻿// <auto-generated />
using System;
using FormCadastro.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FormCadastro.Migrations
{
    [DbContext(typeof(BancoContext))]
    partial class BancoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FormCadastro.Models.TB_CADASTRO", b =>
                {
                    b.Property<Guid>("ID_REGISTRO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BAIRRO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BAIRRO_COMERCIAL_CON")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BAIRRO_COMERCIAL_TIT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP_COMERCIAL_CON")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP_COMERCIAL_TIT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPF_CON")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPF_TIT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DATA_INSCRICAO")
                        .HasColumnType("datetime2");

                    b.Property<string>("DEP10_NASC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP10_NOME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP10_PAREN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP10_RENDA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP11_NASC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP11_NOME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP11_PAREN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP11_RENDA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP1_NASC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP1_NOME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP1_PAREN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP1_RENDA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP2_NASC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP2_NOME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP2_PAREN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP2_RENDA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP3_NASC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP3_NOME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP3_PAREN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP3_RENDA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP4_NASC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP4_NOME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP4_PAREN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP4_RENDA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP5_NASC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP5_NOME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP5_PAREN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP5_RENDA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP6_NASC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP6_NOME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP6_PAREN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP6_RENDA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP7_NASC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP7_NOME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP7_PAREN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP7_RENDA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP8_NASC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP8_NOME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP8_PAREN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP8_RENDA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP9_NASC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP9_NOME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP9_PAREN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DEP9_RENDA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMPRESA_CON")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMPRESA_TIT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ENDERECO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ENDERECO_COMP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ENDERECO_NRO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("END_COMERCIAL_CON")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("END_COMERCIAL_TIT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EST_CIVIL_CON")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EST_CIVIL_TIT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MUNICIPIO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MUNI_COMERCIAL_CON")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MUNI_COMERCIAL_TIT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NASC_CON")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NASC_TIT")
                        .HasColumnType("datetime2");

                    b.Property<string>("NATURAL_CON")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NATURAL_TIT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("NESC_ESP_CON")
                        .HasColumnType("bit");

                    b.Property<string>("NESC_ESP_CON_DESCRICAO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("NESC_ESP_TIT")
                        .HasColumnType("bit");

                    b.Property<string>("NESC_ESP_TIT_DESCRICAO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NOME_CON")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NOME_MAE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NOME_TIT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NRO_COMERCIAL_CON")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NRO_COMERCIAL_TIT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NRO_INSCRICAO")
                        .HasColumnType("int");

                    b.Property<string>("PROF_CON")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PROF_TIT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RENDA_CON")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RENDA_TIT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG_CON")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG_TIT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SEXO_CON")
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("SEXO_TIT")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("TELEFONE_CEL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TELEFONE_RES")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_REGISTRO");

                    b.ToTable("TB_CADASTRO");
                });
#pragma warning restore 612, 618
        }
    }
}
