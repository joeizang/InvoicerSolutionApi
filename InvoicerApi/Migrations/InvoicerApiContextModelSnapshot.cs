﻿// <auto-generated />
using System;
using InvoicerApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InvoicerApi.Migrations
{
    [DbContext(typeof(InvoicerApiContext))]
    partial class InvoicerApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("InvoicerApi.Models.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("InvoicerApi.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("PreferredCurrency")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("InvoicerApi.Models.PlatformInvoice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<DateTimeOffset>("InvoiceIssueDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsTaxable")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("OfferDiscount")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("PlatformInvoiceNumber")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<int>("PlatformInvoiceStatus")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("double");

                    b.Property<int>("TaxCategory")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("PlatformInvoices");
                });

            modelBuilder.Entity("InvoicerApi.Models.PlatformService", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("PlatformInvoiceId")
                        .HasColumnType("char(36)");

                    b.Property<double>("Quantity")
                        .HasColumnType("double");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("PlatformInvoiceId");

                    b.ToTable("PlatformServices");
                });

            modelBuilder.Entity("InvoicerApi.Models.UserInvoice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("DiscountValue")
                        .HasColumnType("double");

                    b.Property<DateTimeOffset>("InvoiceDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("InvoiceNumber")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)");

                    b.Property<string>("InvoiceRecipient")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("InvoiceRecipientAddress")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("InvoiceRecipientEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("InvoiceRecipientPhoneNumber")
                        .HasMaxLength(33)
                        .HasColumnType("varchar(33)");

                    b.Property<string>("InvoiceSpecialNote")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<int>("InvoiceStatus")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceType")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsTaxable")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("OfferDiscount")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("TaxCategory")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserInvoices");
                });

            modelBuilder.Entity("InvoicerApi.Models.UserInvoiceItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<double>("Quantity")
                        .HasColumnType("double");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("UserInvoiceId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("UserInvoiceId");

                    b.ToTable("UserInvoiceItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("InvoicerApi.Models.Address", b =>
                {
                    b.HasOne("InvoicerApi.Models.ApplicationUser", "User")
                        .WithMany("UserAddresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("InvoicerApi.Models.PlatformInvoice", b =>
                {
                    b.HasOne("InvoicerApi.Models.ApplicationUser", "User")
                        .WithMany("PlatformInvoices")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("InvoicerApi.Kernel.Money", "DiscountAmount", b1 =>
                        {
                            b1.Property<Guid>("PlatformInvoiceId")
                                .HasColumnType("char(36)");

                            b1.Property<decimal>("Amount")
                                .HasPrecision(2)
                                .HasColumnType("decimal(2,2)");

                            b1.Property<int>("Currency")
                                .HasColumnType("int");

                            b1.HasKey("PlatformInvoiceId");

                            b1.ToTable("PlatformInvoices");

                            b1.WithOwner()
                                .HasForeignKey("PlatformInvoiceId");
                        });

                    b.OwnsOne("InvoicerApi.Kernel.Money", "TaxAmount", b1 =>
                        {
                            b1.Property<Guid>("PlatformInvoiceId")
                                .HasColumnType("char(36)");

                            b1.Property<decimal>("Amount")
                                .HasPrecision(2)
                                .HasColumnType("decimal(2,2)");

                            b1.Property<int>("Currency")
                                .HasColumnType("int");

                            b1.HasKey("PlatformInvoiceId");

                            b1.ToTable("PlatformInvoices");

                            b1.WithOwner()
                                .HasForeignKey("PlatformInvoiceId");
                        });

                    b.OwnsOne("InvoicerApi.Kernel.Money", "TotalSum", b1 =>
                        {
                            b1.Property<Guid>("PlatformInvoiceId")
                                .HasColumnType("char(36)");

                            b1.Property<decimal>("Amount")
                                .HasPrecision(2)
                                .HasColumnType("decimal(2,2)");

                            b1.Property<int>("Currency")
                                .HasColumnType("int");

                            b1.HasKey("PlatformInvoiceId");

                            b1.ToTable("PlatformInvoices");

                            b1.WithOwner()
                                .HasForeignKey("PlatformInvoiceId");
                        });

                    b.Navigation("DiscountAmount")
                        .IsRequired();

                    b.Navigation("TaxAmount")
                        .IsRequired();

                    b.Navigation("TotalSum")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("InvoicerApi.Models.PlatformService", b =>
                {
                    b.HasOne("InvoicerApi.Models.PlatformInvoice", "PlatformInvoice")
                        .WithMany("PlatformServices")
                        .HasForeignKey("PlatformInvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("InvoicerApi.Kernel.Money", "Price", b1 =>
                        {
                            b1.Property<Guid>("PlatformServiceId")
                                .HasColumnType("char(36)");

                            b1.Property<decimal>("Amount")
                                .HasPrecision(2)
                                .HasColumnType("decimal(2,2)");

                            b1.Property<int>("Currency")
                                .HasColumnType("int");

                            b1.HasKey("PlatformServiceId");

                            b1.ToTable("PlatformServices");

                            b1.WithOwner()
                                .HasForeignKey("PlatformServiceId");
                        });

                    b.Navigation("PlatformInvoice");

                    b.Navigation("Price")
                        .IsRequired();
                });

            modelBuilder.Entity("InvoicerApi.Models.UserInvoice", b =>
                {
                    b.HasOne("InvoicerApi.Models.ApplicationUser", "User")
                        .WithMany("UserInvoices")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("InvoicerApi.Kernel.Money", "DiscountAmount", b1 =>
                        {
                            b1.Property<Guid>("UserInvoiceId")
                                .HasColumnType("char(36)");

                            b1.Property<decimal>("Amount")
                                .HasPrecision(2)
                                .HasColumnType("decimal(2,2)");

                            b1.Property<int>("Currency")
                                .HasColumnType("int");

                            b1.HasKey("UserInvoiceId");

                            b1.ToTable("UserInvoices");

                            b1.WithOwner()
                                .HasForeignKey("UserInvoiceId");
                        });

                    b.OwnsOne("InvoicerApi.Kernel.Money", "TaxAmount", b1 =>
                        {
                            b1.Property<Guid>("UserInvoiceId")
                                .HasColumnType("char(36)");

                            b1.Property<decimal>("Amount")
                                .HasPrecision(2)
                                .HasColumnType("decimal(2,2)");

                            b1.Property<int>("Currency")
                                .HasColumnType("int");

                            b1.HasKey("UserInvoiceId");

                            b1.ToTable("UserInvoices");

                            b1.WithOwner()
                                .HasForeignKey("UserInvoiceId");
                        });

                    b.OwnsOne("InvoicerApi.Kernel.Money", "TotalInvoicedAmount", b1 =>
                        {
                            b1.Property<Guid>("UserInvoiceId")
                                .HasColumnType("char(36)");

                            b1.Property<decimal>("Amount")
                                .HasPrecision(2)
                                .HasColumnType("decimal(2,2)");

                            b1.Property<int>("Currency")
                                .HasColumnType("int");

                            b1.HasKey("UserInvoiceId");

                            b1.ToTable("UserInvoices");

                            b1.WithOwner()
                                .HasForeignKey("UserInvoiceId");
                        });

                    b.Navigation("DiscountAmount")
                        .IsRequired();

                    b.Navigation("TaxAmount")
                        .IsRequired();

                    b.Navigation("TotalInvoicedAmount")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("InvoicerApi.Models.UserInvoiceItem", b =>
                {
                    b.HasOne("InvoicerApi.Models.UserInvoice", "UserInvoice")
                        .WithMany("InvoiceItems")
                        .HasForeignKey("UserInvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("InvoicerApi.Kernel.Money", "Amount", b1 =>
                        {
                            b1.Property<Guid>("UserInvoiceItemId")
                                .HasColumnType("char(36)");

                            b1.Property<decimal>("Amount")
                                .HasPrecision(2)
                                .HasColumnType("decimal(2,2)");

                            b1.Property<int>("Currency")
                                .HasMaxLength(3)
                                .HasColumnType("int")
                                .IsFixedLength();

                            b1.HasKey("UserInvoiceItemId");

                            b1.ToTable("UserInvoiceItems");

                            b1.WithOwner()
                                .HasForeignKey("UserInvoiceItemId");
                        });

                    b.Navigation("Amount")
                        .IsRequired();

                    b.Navigation("UserInvoice");
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
                    b.HasOne("InvoicerApi.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("InvoicerApi.Models.ApplicationUser", null)
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

                    b.HasOne("InvoicerApi.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("InvoicerApi.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InvoicerApi.Models.ApplicationUser", b =>
                {
                    b.Navigation("PlatformInvoices");

                    b.Navigation("UserAddresses");

                    b.Navigation("UserInvoices");
                });

            modelBuilder.Entity("InvoicerApi.Models.PlatformInvoice", b =>
                {
                    b.Navigation("PlatformServices");
                });

            modelBuilder.Entity("InvoicerApi.Models.UserInvoice", b =>
                {
                    b.Navigation("InvoiceItems");
                });
#pragma warning restore 612, 618
        }
    }
}
