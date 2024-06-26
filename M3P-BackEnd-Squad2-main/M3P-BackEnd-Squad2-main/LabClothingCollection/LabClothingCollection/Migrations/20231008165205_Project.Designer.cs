﻿// <auto-generated />
using System;
using LabClothingCollection.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LabClothingCollection.Migrations
{
    [DbContext(typeof(LCCContext))]
    [Migration("20231008165205_Project")]
    partial class Project
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LabClothingCollection.Models.ClothingCollection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Budget")
                        .HasColumnType("float");

                    b.Property<string>("CollectionColors")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("LaunchStation")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ReleaseYearCollection")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdUser");

                    b.ToTable("Collections");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Adidas",
                            Budget = 70000.0,
                            CollectionColors = "",
                            IdUser = "1",
                            LaunchStation = 1,
                            Name = "Primavera 2023",
                            ReleaseYearCollection = 2023,
                            Status = 2
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Nike",
                            Budget = 80000.0,
                            CollectionColors = "Azul e Amarelo",
                            IdUser = "2",
                            LaunchStation = 2,
                            Name = "Verão 2023",
                            ReleaseYearCollection = 2023,
                            Status = 2
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Puma",
                            Budget = 75000.0,
                            CollectionColors = "Vermelho e Marrom",
                            IdUser = "3",
                            LaunchStation = 3,
                            Name = "Outono 2023",
                            ReleaseYearCollection = 2023,
                            Status = 2
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Reebok",
                            Budget = 90000.0,
                            CollectionColors = "Preto e Branco",
                            IdUser = "4",
                            LaunchStation = 4,
                            Name = "Inverno 2023",
                            ReleaseYearCollection = 2023,
                            Status = 2
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Under Armour",
                            Budget = 85000.0,
                            CollectionColors = "Verde e Laranja",
                            IdUser = "5",
                            LaunchStation = 2,
                            Name = "Verão 2024",
                            ReleaseYearCollection = 2024,
                            Status = 2
                        },
                        new
                        {
                            Id = 6,
                            Brand = "New Balance",
                            Budget = 72000.0,
                            CollectionColors = "Cinza e Marrom",
                            IdUser = "6",
                            LaunchStation = 3,
                            Name = "Outono 2024",
                            ReleaseYearCollection = 2024,
                            Status = 2
                        });
                });

            modelBuilder.Entity("LabClothingCollection.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("DarkModePrimary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DarkModeSecondary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DefaultTheme")
                        .HasColumnType("int");

                    b.Property<string>("LightModePrimary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LightModeSecondary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CNPJ = "57154704000136",
                            DarkModePrimary = "",
                            DarkModeSecondary = "",
                            DefaultTheme = 1,
                            LightModePrimary = "",
                            LightModeSecondary = "",
                            Logo = "",
                            Name = "TechSolutions Inc."
                        },
                        new
                        {
                            Id = 2,
                            CNPJ = "16854346000197",
                            DarkModePrimary = "",
                            DarkModeSecondary = "",
                            DefaultTheme = 1,
                            LightModePrimary = "",
                            LightModeSecondary = "",
                            Logo = "",
                            Name = "ByteWave Technologies"
                        });
                });

            modelBuilder.Entity("LabClothingCollection.Models.GetHelp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("GetHelp");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Text = "No Sidebar, selecionar Coleções. Na página de Coleções, clicar no botão Criar Coleção. Após efetuar as alterações, clicar no Botão Salvar.",
                            Title = "Como Criar uma Coleção"
                        },
                        new
                        {
                            Id = 2,
                            Text = "No Sidebar, selecionar Modelos. Na página de Modelos, clicar no botão Criar Modelo. Após efetuar as alterações, clicar no Botão Salvar.",
                            Title = "Como Criar um Modelo"
                        });
                });

            modelBuilder.Entity("LabClothingCollection.Models.ModelClothing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<bool>("Embroidered")
                        .HasColumnType("bit");

                    b.Property<int>("IdCCollection")
                        .HasColumnType("int");

                    b.Property<string>("IdUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Print")
                        .HasColumnType("bit");

                    b.Property<int>("TypeModel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCCollection");

                    b.HasIndex("IdUser");

                    b.ToTable("Models");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cost = 10000.0,
                            Embroidered = false,
                            IdCCollection = 5,
                            IdUser = "1",
                            Name = "Camisa com Capuz",
                            Print = true,
                            TypeModel = 7
                        },
                        new
                        {
                            Id = 2,
                            Cost = 10000.0,
                            Embroidered = false,
                            IdCCollection = 1,
                            IdUser = "2",
                            Name = "Shorts de Verão",
                            Print = true,
                            TypeModel = 1
                        },
                        new
                        {
                            Id = 3,
                            Cost = 12000.0,
                            Embroidered = true,
                            IdCCollection = 1,
                            IdUser = "3",
                            Name = "Bermuda Jeans",
                            Print = false,
                            TypeModel = 1
                        },
                        new
                        {
                            Id = 4,
                            Cost = 11000.0,
                            Embroidered = false,
                            IdCCollection = 1,
                            IdUser = "4",
                            Name = "Camiseta Casual",
                            Print = true,
                            TypeModel = 7
                        },
                        new
                        {
                            Id = 5,
                            Cost = 8000.0,
                            Embroidered = true,
                            IdCCollection = 1,
                            IdUser = "5",
                            Name = "Camisa Social",
                            Print = false,
                            TypeModel = 7
                        },
                        new
                        {
                            Id = 6,
                            Cost = 13000.0,
                            Embroidered = false,
                            IdCCollection = 2,
                            IdUser = "6",
                            Name = "Saia de Verão",
                            Print = true,
                            TypeModel = 9
                        },
                        new
                        {
                            Id = 7,
                            Cost = 13500.0,
                            Embroidered = true,
                            IdCCollection = 2,
                            IdUser = "4",
                            Name = "Calça Jeans Skinny",
                            Print = false,
                            TypeModel = 5
                        },
                        new
                        {
                            Id = 8,
                            Cost = 9000.0,
                            Embroidered = false,
                            IdCCollection = 2,
                            IdUser = "5",
                            Name = "Calça de Couro",
                            Print = false,
                            TypeModel = 5
                        },
                        new
                        {
                            Id = 9,
                            Cost = 5000.0,
                            Embroidered = true,
                            IdCCollection = 3,
                            IdUser = "6",
                            Name = "Blusa de Tricô",
                            Print = false,
                            TypeModel = 7
                        },
                        new
                        {
                            Id = 10,
                            Cost = 8000.0,
                            Embroidered = false,
                            IdCCollection = 3,
                            IdUser = "1",
                            Name = "Calça de Moletom",
                            Print = true,
                            TypeModel = 5
                        },
                        new
                        {
                            Id = 11,
                            Cost = 6000.0,
                            Embroidered = true,
                            IdCCollection = 3,
                            IdUser = "2",
                            Name = "Camisa Polo",
                            Print = false,
                            TypeModel = 7
                        },
                        new
                        {
                            Id = 12,
                            Cost = 7600.0,
                            Embroidered = false,
                            IdCCollection = 4,
                            IdUser = "3",
                            Name = "Saia Midi",
                            Print = true,
                            TypeModel = 9
                        },
                        new
                        {
                            Id = 13,
                            Cost = 14000.0,
                            Embroidered = true,
                            IdCCollection = 4,
                            IdUser = "4",
                            Name = "Boné Clássico",
                            Print = false,
                            TypeModel = 4
                        },
                        new
                        {
                            Id = 14,
                            Cost = 9400.0,
                            Embroidered = false,
                            IdCCollection = 5,
                            IdUser = "6",
                            Name = "Shorts Esportivos",
                            Print = false,
                            TypeModel = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("LabClothingCollection.Models.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<int>("IdCompany")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserStatus")
                        .HasColumnType("int");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasIndex("IdCompany");

                    b.HasDiscriminator().HasValue("User");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bad80ab8-1dd4-40f2-9a91-172d32965f20",
                            Email = "clei.lisboa@ts.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "CLEI.LISBOA@TS.COM",
                            NormalizedUserName = "CLEI.LISBOA@TS.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPnBP8WhKkaapHEOFkids06ixRpo7ISDgalBzqQoZkjN2LPsr1ruURmplKcNa6m2LQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2b02e4e6-12e1-4185-9368-bfb14aef38c5",
                            TwoFactorEnabled = false,
                            UserName = "clei.lisboa@ts.com",
                            IdCompany = 1,
                            Name = "Clei Lisboa",
                            Password = "!Ab12345",
                            UserStatus = 1,
                            UserType = 1
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d22589d4-bae3-49f9-b42a-b0644a39b986",
                            Email = "sophia.lisboa@ts.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "SOPHIA.LISBOA@TS.COM",
                            NormalizedUserName = "SOPHIA.LISBOA@TS.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPnBP8WhKkaapHEOFkids06ixRpo7ISDgalBzqQoZkjN2LPsr1ruURmplKcNa6m2LQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4fe5a41a-bd2e-4bf6-b155-a07b5b9b40ec",
                            TwoFactorEnabled = false,
                            UserName = "sophia.lisboa@ts.com",
                            IdCompany = 1,
                            Name = "Sophia Lisboa",
                            Password = "!Ab12345",
                            UserStatus = 1,
                            UserType = 3
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0de27f24-9b43-4912-b2dd-c4165137eec7",
                            Email = "pamela.lisboa@ts.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "PAMELA.LISBOATS.COM",
                            NormalizedUserName = "PAMELA.LISBOATS.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPnBP8WhKkaapHEOFkids06ixRpo7ISDgalBzqQoZkjN2LPsr1ruURmplKcNa6m2LQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0a9220e5-baf2-4964-bcf8-908b689c3b77",
                            TwoFactorEnabled = false,
                            UserName = "pamela.lisboa@ts.com",
                            IdCompany = 1,
                            Name = "Pamela Lisboa",
                            Password = "!Ab12345",
                            UserStatus = 1,
                            UserType = 3
                        },
                        new
                        {
                            Id = "4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "171664eb-e87e-420d-9ce7-b9af58627ef3",
                            Email = "raphael.carvalho@bt.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "RAPHAEL.CARVALHO@BT.COM",
                            NormalizedUserName = "RAPHAEL.CARVALHO@BT.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPnBP8WhKkaapHEOFkids06ixRpo7ISDgalBzqQoZkjN2LPsr1ruURmplKcNa6m2LQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "59f8a151-d163-412f-b5b5-48d71df6cbc7",
                            TwoFactorEnabled = false,
                            UserName = "raphael.carvalho@bt.com",
                            IdCompany = 2,
                            Name = "Raphael Carvalho",
                            Password = "!Ab12345",
                            UserStatus = 1,
                            UserType = 1
                        },
                        new
                        {
                            Id = "5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a846e0d9-7d67-4a0f-b3db-8622b2b590bd",
                            Email = "rafaela.carvalho@bt.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "RAFAELA.CARVALHO@BT.COM",
                            NormalizedUserName = "RAFAELA.CARVALHO@BT.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPnBP8WhKkaapHEOFkids06ixRpo7ISDgalBzqQoZkjN2LPsr1ruURmplKcNa6m2LQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "32efc2d0-7cef-4286-9e77-575b05f6acfe",
                            TwoFactorEnabled = false,
                            UserName = "rafaela.carvalho@bt.com",
                            IdCompany = 2,
                            Name = "Rafaela Carvalho",
                            Password = "!Ab12345",
                            UserStatus = 1,
                            UserType = 3
                        },
                        new
                        {
                            Id = "6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ff6d968d-e76b-4400-89b5-0b7b20ef080c",
                            Email = "rosangela.carvalho@bt.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "ROSANGELA.CARVALHO@BT.COM",
                            NormalizedUserName = "ROSANGELA.CARVALHO@BT.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPnBP8WhKkaapHEOFkids06ixRpo7ISDgalBzqQoZkjN2LPsr1ruURmplKcNa6m2LQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e7b17086-2bbd-45b2-a5f8-7feb8a1c6ca0",
                            TwoFactorEnabled = false,
                            UserName = "rosangela.carvalho@bt.com",
                            IdCompany = 2,
                            Name = "Rosângela Carvalho",
                            Password = "!Ab12345",
                            UserStatus = 1,
                            UserType = 3
                        });
                });

            modelBuilder.Entity("LabClothingCollection.Models.ClothingCollection", b =>
                {
                    b.HasOne("LabClothingCollection.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LabClothingCollection.Models.ModelClothing", b =>
                {
                    b.HasOne("LabClothingCollection.Models.ClothingCollection", "ClothingCollection")
                        .WithMany()
                        .HasForeignKey("IdCCollection")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabClothingCollection.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClothingCollection");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LabClothingCollection.Models.User", b =>
                {
                    b.HasOne("LabClothingCollection.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("IdCompany")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });
#pragma warning restore 612, 618
        }
    }
}
