﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PatientPortal.Data;

namespace PatientPortal.Migrations
{
    [DbContext(typeof(PatientPortalContext))]
    [Migration("20210814213158_Rev2Patient")]
    partial class Rev2Patient
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PatientPortal.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ActivePatient")
                        .HasColumnType("bit");

                    b.Property<string>("Apartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentBalance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prefix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryInsurance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryInsuranceHolder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryInsuranceID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondaryInsurance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondaryInsuranceHolder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondaryInsuranceID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ssn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Suffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientId");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("PatientPortal.Models.Referral", b =>
                {
                    b.Property<int>("ReferralId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Doctor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EditedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Procedure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReferralDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReferralDoctor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReferralId");

                    b.HasIndex("PatientId");

                    b.ToTable("Referral");
                });

            modelBuilder.Entity("PatientPortal.Models.Referral", b =>
                {
                    b.HasOne("PatientPortal.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });
#pragma warning restore 612, 618
        }
    }
}
