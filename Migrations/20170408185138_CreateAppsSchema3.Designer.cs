using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Contracts_Module_Sample.Models;

namespace Contracts_Module_Sample.Migrations
{
    [DbContext(typeof(Contracts_Module_SampleContext))]
    [Migration("20170408185138_CreateAppsSchema3")]
    partial class CreateAppsSchema3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Contracts_Module_Sample.Models.Attachment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ContractID");

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("EditDate");

                    b.Property<byte[]>("File");

                    b.Property<int?>("TaskID");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("ContractID");

                    b.HasIndex("TaskID");

                    b.ToTable("Attachment");
                });

            modelBuilder.Entity("Contracts_Module_Sample.Models.CMSTask", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ContractID");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EditDate");

                    b.Property<bool>("IsComleted");

                    b.Property<string>("Status");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("ContractID");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("Contracts_Module_Sample.Models.Contract", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ContractorID");

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("EditDate");

                    b.Property<string>("Status");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("ContractorID");

                    b.ToTable("Contract");
                });

            modelBuilder.Entity("Contracts_Module_Sample.Models.Contractor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ExpiredDate");

                    b.Property<int>("State");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Contractor");
                });

            modelBuilder.Entity("Contracts_Module_Sample.Models.Attachment", b =>
                {
                    b.HasOne("Contracts_Module_Sample.Models.Contract", "Contract")
                        .WithMany("Attachments")
                        .HasForeignKey("ContractID");

                    b.HasOne("Contracts_Module_Sample.Models.CMSTask", "Task")
                        .WithMany("Attachments")
                        .HasForeignKey("TaskID");
                });

            modelBuilder.Entity("Contracts_Module_Sample.Models.CMSTask", b =>
                {
                    b.HasOne("Contracts_Module_Sample.Models.Contract", "Contract")
                        .WithMany("Tasks")
                        .HasForeignKey("ContractID");
                });

            modelBuilder.Entity("Contracts_Module_Sample.Models.Contract", b =>
                {
                    b.HasOne("Contracts_Module_Sample.Models.Contractor", "Contractor")
                        .WithMany()
                        .HasForeignKey("ContractorID");
                });
        }
    }
}
