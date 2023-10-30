﻿// <auto-generated />
using AT20231030_MediaAluno.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AT20231030_MediaAluno.Migrations
{
    [DbContext(typeof(AT20231030_MediaAlunoContext))]
    partial class AT20231030_MediaAlunoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AT20231030_MediaAluno.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DataNasc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Media")
                        .HasColumnType("float");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeMae")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomePai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Nota1")
                        .HasColumnType("float");

                    b.Property<double>("Nota2")
                        .HasColumnType("float");

                    b.Property<double>("Nota3")
                        .HasColumnType("float");

                    b.Property<double>("Nota4")
                        .HasColumnType("float");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Aluno");
                });
#pragma warning restore 612, 618
        }
    }
}
