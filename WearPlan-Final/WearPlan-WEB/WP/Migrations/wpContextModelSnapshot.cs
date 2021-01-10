﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace WP.Migrations
{
    [DbContext(typeof(wpContext))]
    partial class wpContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10");

            modelBuilder.Entity("WP.Models.Client", b =>
                {
                    b.Property<int>("idClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .HasColumnType("TEXT");

                    b.HasKey("idClient");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("WP.Models.Customer", b =>
                {
                    b.Property<int>("idCustomer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .HasColumnType("TEXT");

                    b.HasKey("idCustomer");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("WP.Models.Product", b =>
                {
                    b.Property<int>("idProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("brand")
                        .HasColumnType("TEXT");

                    b.Property<string>("category")
                        .HasColumnType("TEXT");

                    b.Property<string>("client")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("discount")
                        .HasColumnType("TEXT");

                    b.Property<string>("image")
                        .HasColumnType("TEXT");

                    b.Property<string>("model")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("price")
                        .HasColumnType("TEXT");

                    b.Property<string>("sex")
                        .HasColumnType("TEXT");

                    b.Property<string>("size")
                        .HasColumnType("TEXT");

                    b.Property<string>("specs")
                        .HasColumnType("TEXT");

                    b.Property<string>("code")
                        .HasColumnType("TEXT");

                    b.HasKey("idProduct");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("WP.Models.ProductPurchase", b =>
                {
                    b.Property<int>("idProductPurchase")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("idProduct")
                        .HasColumnType("INTEGER");

                    b.Property<int>("idPurchase")
                        .HasColumnType("INTEGER");

                    b.HasKey("idProductPurchase");

                    b.ToTable("ProductPurchase");
                });

            modelBuilder.Entity("WP.Models.Purchase", b =>
                {
                    b.Property<int>("idPurchase")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("idCustomer")
                        .HasColumnType("TEXT");

                    b.Property<int>("idProduct")
                        .HasColumnType("INTEGER");

                    b.HasKey("idPurchase");

                    b.ToTable("Purchase");
                });

            modelBuilder.Entity("WP.Models.Selection", b =>
                {
                    b.Property<int>("idSelection")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("idDiscount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("idProduct")
                        .HasColumnType("INTEGER");

                    b.HasKey("idSelection");

                    b.ToTable("Selection");
                });

            modelBuilder.Entity("WP.Models.Subscriber", b =>
                {
                    b.Property<int>("idSubscriber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("idClient")
                        .HasColumnType("INTEGER");

                    b.Property<string>("status")
                        .HasColumnType("TEXT");

                    b.HasKey("idSubscriber");

                    b.ToTable("Subscriber");
                });
#pragma warning restore 612, 618
        }
    }
}
