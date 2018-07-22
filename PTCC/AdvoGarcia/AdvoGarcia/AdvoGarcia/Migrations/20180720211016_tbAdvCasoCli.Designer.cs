using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using AdvoGarcia;

namespace AdvoGarcia.Migrations
{
    [DbContext(typeof(EntidadesContext))]
    [Migration("20180720211016_tbAdvCasoCli")]
    partial class tbAdvCasoCli
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdvoGarcia.Entidades.Advogado", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CPF");

                    b.Property<string>("Email");

                    b.Property<string>("Endedreco");

                    b.Property<string>("Especializacao");

                    b.Property<string>("Foto");

                    b.Property<DateTime>("LastLog");

                    b.Property<string>("Nascimento");

                    b.Property<string>("Nome");

                    b.Property<string>("Pass");

                    b.Property<int>("PrecoPorHR");

                    b.Property<int>("QtdCasos");

                    b.Property<string>("Telefone");

                    b.Property<string>("User");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("AdvoGarcia.Entidades.Caso", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AdvogadoID");

                    b.Property<int>("ClienteID");

                    b.Property<string>("Descricao");

                    b.Property<string>("Status");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("AdvoGarcia.Entidades.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CPF");

                    b.Property<string>("Email");

                    b.Property<string>("Endedreco");

                    b.Property<string>("FormaPagamento");

                    b.Property<string>("Foto");

                    b.Property<string>("Nome");

                    b.Property<string>("Pass");

                    b.Property<int>("Telefone");

                    b.Property<string>("User");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("AdvoGarcia.Entidades.Caso", b =>
                {
                    b.HasOne("AdvoGarcia.Entidades.Advogado")
                        .WithMany()
                        .HasForeignKey("AdvogadoID");

                    b.HasOne("AdvoGarcia.Entidades.Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID");
                });
        }
    }
}
