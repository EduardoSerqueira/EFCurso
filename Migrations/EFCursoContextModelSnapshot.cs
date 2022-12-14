// <auto-generated />
using System;
using EFCurso.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCurso.Migrations
{
    [DbContext(typeof(EFCursoContext))]
    partial class EFCursoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EFCurso.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Nome");

                    b.Property<float>("Salario");

                    b.HasKey("Id");

                    b.ToTable("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}
