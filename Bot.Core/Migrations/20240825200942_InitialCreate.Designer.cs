﻿// <auto-generated />
using System;
using Bot.Core.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bot.Core.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240825200942_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Bot.Core.Model.Estudante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<bool>("AtualizarPorEmail")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_atualizar_por_email");

                    b.Property<bool>("AtualizarPorWhatsapp")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_atualizar_por_whatsapp");

                    b.Property<bool>("Autenticado")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("autenticado");

                    b.Property<string>("Cpf")
                        .HasColumnType("longtext")
                        .HasColumnName("cpf");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<bool>("Logado")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("logado");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.Property<string>("Senha")
                        .HasColumnType("longtext")
                        .HasColumnName("senha");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<string>("Whatsapp")
                        .HasColumnType("longtext")
                        .HasColumnName("whatsapp");

                    b.HasKey("Id");

                    b.ToTable("estudante");
                });

            modelBuilder.Entity("Bot.Core.Model.MateriaMatriculado", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Codigo")
                        .HasColumnType("longtext")
                        .HasColumnName("codigo");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("deleted_at");

                    b.Property<int?>("EstudanteId")
                        .HasColumnType("int")
                        .HasColumnName("estudante_id");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.Property<int?>("NotasId")
                        .HasColumnType("int")
                        .HasColumnName("notas_id");

                    b.Property<string>("Professor")
                        .HasColumnType("longtext")
                        .HasColumnName("professor");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("EstudanteId");

                    b.HasIndex("NotasId");

                    b.ToTable("materia_matriculado");
                });

            modelBuilder.Entity("Bot.Core.Model.Notas", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("deleted_at");

                    b.Property<float?>("MediaFinal")
                        .HasColumnType("float")
                        .HasColumnName("media_final");

                    b.Property<float?>("P1")
                        .HasColumnType("float")
                        .HasColumnName("p1");

                    b.Property<float?>("P2")
                        .HasColumnType("float")
                        .HasColumnName("p2");

                    b.Property<float?>("P3")
                        .HasColumnType("float")
                        .HasColumnName("p3");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("notas");
                });

            modelBuilder.Entity("Bot.Core.Model.MateriaMatriculado", b =>
                {
                    b.HasOne("Bot.Core.Model.Estudante", null)
                        .WithMany("MateriasMatriculadas")
                        .HasForeignKey("EstudanteId");

                    b.HasOne("Bot.Core.Model.Notas", "Notas")
                        .WithMany()
                        .HasForeignKey("NotasId");

                    b.Navigation("Notas");
                });

            modelBuilder.Entity("Bot.Core.Model.Estudante", b =>
                {
                    b.Navigation("MateriasMatriculadas");
                });
#pragma warning restore 612, 618
        }
    }
}
