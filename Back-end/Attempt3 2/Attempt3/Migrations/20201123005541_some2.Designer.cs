﻿// <auto-generated />
using Attempt3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Attempt3.Migrations
{
    [DbContext(typeof(MyContext2))]
    [Migration("20201123005541_some2")]
    partial class some2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Attempt3.Models.Brand", b =>
                {
                    b.Property<int>("idBrand")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("brand")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idBrand");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("Attempt3.Models.Category", b =>
                {
                    b.Property<int>("idCategory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("category")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCategory");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Attempt3.Models.Client", b =>
                {
                    b.Property<int>("idClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shopName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idClient");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Attempt3.Models.Customer", b =>
                {
                    b.Property<int>("idCustomer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("discount")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idWardrobe")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCustomer");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Attempt3.Models.Discount", b =>
                {
                    b.Property<int>("idDiscount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("discount")
                        .HasColumnType("int");

                    b.Property<int>("idProduct")
                        .HasColumnType("int");

                    b.HasKey("idDiscount");

                    b.ToTable("Discount");
                });

            modelBuilder.Entity("Attempt3.Models.Product", b =>
                {
                    b.Property<int>("idProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idBrand")
                        .HasColumnType("int");

                    b.Property<int>("idCategory")
                        .HasColumnType("int");

                    b.Property<int>("idClient")
                        .HasColumnType("int");

                    b.Property<int>("idDiscount")
                        .HasColumnType("int");

                    b.Property<int>("idSize")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("specs")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idProduct");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Attempt3.Models.ProductBrand", b =>
                {
                    b.Property<int>("idProductBrand")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idBrand")
                        .HasColumnType("int");

                    b.Property<int>("idProduct")
                        .HasColumnType("int");

                    b.HasKey("idProductBrand");

                    b.ToTable("ProductBrand");
                });

            modelBuilder.Entity("Attempt3.Models.ProductCategory", b =>
                {
                    b.Property<int>("idProductCategory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idCategory")
                        .HasColumnType("int");

                    b.Property<int>("idProduct")
                        .HasColumnType("int");

                    b.HasKey("idProductCategory");

                    b.ToTable("ProductCategory");
                });

            modelBuilder.Entity("Attempt3.Models.ProductPurchase", b =>
                {
                    b.Property<int>("idProductPurchase")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idProduct")
                        .HasColumnType("int");

                    b.Property<int>("idPurchase")
                        .HasColumnType("int");

                    b.HasKey("idProductPurchase");

                    b.ToTable("ProductPurchase");
                });

            modelBuilder.Entity("Attempt3.Models.ProductSize", b =>
                {
                    b.Property<int>("idProductSize")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idProduct")
                        .HasColumnType("int");

                    b.Property<int>("idSize")
                        .HasColumnType("int");

                    b.HasKey("idProductSize");

                    b.ToTable("ProductSize");
                });

            modelBuilder.Entity("Attempt3.Models.Purchase", b =>
                {
                    b.Property<int>("idPurchase")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idCustomer")
                        .HasColumnType("int");

                    b.Property<int>("idProduct")
                        .HasColumnType("int");

                    b.HasKey("idPurchase");

                    b.ToTable("Purchase");
                });

            modelBuilder.Entity("Attempt3.Models.Selection", b =>
                {
                    b.Property<int>("idSelection")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idDiscount")
                        .HasColumnType("int");

                    b.Property<int>("idProduct")
                        .HasColumnType("int");

                    b.Property<int>("idWardrobe")
                        .HasColumnType("int");

                    b.HasKey("idSelection");

                    b.ToTable("Selection");
                });

            modelBuilder.Entity("Attempt3.Models.Size", b =>
                {
                    b.Property<int>("idSize")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("size")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idSize");

                    b.ToTable("Size");
                });

            modelBuilder.Entity("Attempt3.Models.Subscriber", b =>
                {
                    b.Property<int>("idSubscriber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idClient")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idSubscriber");

                    b.ToTable("Subscriber");
                });

            modelBuilder.Entity("Attempt3.Models.Wardrobe", b =>
                {
                    b.Property<int>("idWardrobe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idCustomer")
                        .HasColumnType("int");

                    b.Property<int>("idProduct")
                        .HasColumnType("int");

                    b.HasKey("idWardrobe");

                    b.ToTable("Wardrobe");
                });
#pragma warning restore 612, 618
        }
    }
}
