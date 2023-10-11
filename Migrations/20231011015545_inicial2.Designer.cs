﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebTreinosAcademia.Models;

#nullable disable

namespace WebTreinosAcademia.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231011015545_inicial2")]
    partial class inicial2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebTreinosAcademia.Models.Aluno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("cidade")
                        .HasMaxLength(25)
                        .HasColumnType("int");

                    b.Property<int>("cpf")
                        .HasMaxLength(14)
                        .HasColumnType("int");

                    b.Property<DateTime>("datanasc")
                        .HasColumnType("datetime2");

                    b.Property<string>("endereco")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("idade")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ojetivo")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<float>("peso")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("WebTreinosAcademia.Models.Professor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("endereco")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("especializacao")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("idade")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("sexo")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("id");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("WebTreinosAcademia.Models.Treino", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("descricaotreino")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("dificuldade")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("duracao")
                        .HasColumnType("int");

                    b.Property<string>("nometreino")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("professorRespid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("professorRespid");

                    b.ToTable("Treinos");
                });

            modelBuilder.Entity("WebTreinosAcademia.Models.Treino", b =>
                {
                    b.HasOne("WebTreinosAcademia.Models.Professor", "professorResp")
                        .WithMany()
                        .HasForeignKey("professorRespid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("professorResp");
                });
#pragma warning restore 612, 618
        }
    }
}
