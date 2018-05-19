using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using AdvoGarcia;

namespace AdvoGarcia.Migrations
{
    [DbContext(typeof(EntidadesContext))]
    partial class EntidadesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdvoGarcia.Entidades.Advogado", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CPF");

                    b.Property<string>("Email");

                    b.Property<string>("Endedreco");

                    b.Property<string>("Especializacao");

                    b.Property<int?>("IDCasoID");

                    b.Property<string>("Nome");

                    b.Property<string>("Pass");

                    b.Property<int>("PrecoPorHR");

                    b.Property<int>("QtdCasos");

                    b.Property<int>("Telefone");

                    b.Property<string>("User");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("AdvoGarcia.Entidades.Caso", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<string>("Status");

                    b.Property<int>("TempoTotal");

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

                    b.Property<int?>("IDCasoID");

                    b.Property<string>("Nome");

                    b.Property<string>("Pass");

                    b.Property<int>("Telefone");

                    b.Property<string>("User");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("AdvoGarcia.Entidades.Advogado", b =>
                {
                    b.HasOne("AdvoGarcia.Entidades.Caso")
                        .WithMany()
                        .HasForeignKey("IDCasoID");
                });

            modelBuilder.Entity("AdvoGarcia.Entidades.Cliente", b =>
                {
                    b.HasOne("AdvoGarcia.Entidades.Caso")
                        .WithMany()
                        .HasForeignKey("IDCasoID");
                });
        }
    }
}
