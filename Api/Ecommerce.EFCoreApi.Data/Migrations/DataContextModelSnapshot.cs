﻿// <auto-generated />
using System;
using Ecommerce.EFCoreApi.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce.EFCoreApi.Data.migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Modified_at")
                        .HasColumnType("datetime");

                    b.Property<int>("Product_id")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Session_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Product_id")
                        .IsUnique();

                    b.HasIndex("Session_Id");

                    b.ToTable("Cart", (string)null);
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Discount_Percent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Discounts", (string)null);
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Modified_At")
                        .HasColumnType("datetime");

                    b.Property<int>("Payment_Id")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Payment_Id")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Order Details", (string)null);
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.OrderItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Modified_At")
                        .HasColumnType("datetime");

                    b.Property<int>("Order_Id")
                        .HasColumnType("int");

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Order_Id");

                    b.HasIndex("Product_Id")
                        .IsUnique();

                    b.ToTable("Order_Items", (string)null);
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.PaymentDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Modified_At")
                        .HasColumnType("datetime");

                    b.Property<int>("Order_id")
                        .HasColumnType("int");

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Payment Details", (string)null);
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("Text");

                    b.Property<int>("DiscountId")
                        .HasColumnType("int");

                    b.Property<int>("InventoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Product_Sku")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DiscountId");

                    b.HasIndex("InventoryId")
                        .IsUnique();

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.ProductInventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("ProductInventories", (string)null);
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Modified_At")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("User_Id")
                        .IsUnique();

                    b.ToTable("Session", (string)null);
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Telephone")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.UserAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address_line1")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Address_line2")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("User_id");

                    b.ToTable("UserAddress", (string)null);
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.UserPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Account_no")
                        .HasColumnType("int");

                    b.Property<DateTime>("Expiry")
                        .HasColumnType("date");

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.Property<string>("payment_type")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("User_id");

                    b.ToTable("UserPayment", (string)null);
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.Cart", b =>
                {
                    b.HasOne("Ecommerce.EFCoreApi.Domain.Entities.Product", "Product")
                        .WithOne("Cart")
                        .HasForeignKey("Ecommerce.EFCoreApi.Domain.Entities.Cart", "Product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.EFCoreApi.Domain.Entities.Session", "Session")
                        .WithMany("Carts")
                        .HasForeignKey("Session_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Session");
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.OrderDetails", b =>
                {
                    b.HasOne("Ecommerce.EFCoreApi.Domain.Entities.PaymentDetails", "PaymentDetails")
                        .WithOne("OrderDetails")
                        .HasForeignKey("Ecommerce.EFCoreApi.Domain.Entities.OrderDetails", "Payment_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.EFCoreApi.Domain.Entities.User", "User")
                        .WithOne("OrderDetails")
                        .HasForeignKey("Ecommerce.EFCoreApi.Domain.Entities.OrderDetails", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentDetails");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.OrderItems", b =>
                {
                    b.HasOne("Ecommerce.EFCoreApi.Domain.Entities.OrderDetails", "OrderDetails")
                        .WithMany("OrderItems")
                        .HasForeignKey("Order_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.EFCoreApi.Domain.Entities.Product", "Product")
                        .WithOne("OrderItems")
                        .HasForeignKey("Ecommerce.EFCoreApi.Domain.Entities.OrderItems", "Product_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderDetails");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.Product", b =>
                {
                    b.HasOne("Ecommerce.EFCoreApi.Domain.Entities.Categories", "Categories")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Ecommerce.EFCoreApi.Domain.Entities.Discount", "Discount")
                        .WithMany("Products")
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.EFCoreApi.Domain.Entities.ProductInventory", "Inventory")
                        .WithOne("Product")
                        .HasForeignKey("Ecommerce.EFCoreApi.Domain.Entities.Product", "InventoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Categories");

                    b.Navigation("Discount");

                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.Session", b =>
                {
                    b.HasOne("Ecommerce.EFCoreApi.Domain.Entities.User", "User")
                        .WithOne("Session")
                        .HasForeignKey("Ecommerce.EFCoreApi.Domain.Entities.Session", "User_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.UserAddress", b =>
                {
                    b.HasOne("Ecommerce.EFCoreApi.Domain.Entities.User", "User")
                        .WithMany("UserAddresses")
                        .HasForeignKey("User_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.UserPayment", b =>
                {
                    b.HasOne("Ecommerce.EFCoreApi.Domain.Entities.User", "User")
                        .WithMany("UserPayments")
                        .HasForeignKey("User_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.Categories", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.Discount", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.OrderDetails", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.PaymentDetails", b =>
                {
                    b.Navigation("OrderDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.Product", b =>
                {
                    b.Navigation("Cart")
                        .IsRequired();

                    b.Navigation("OrderItems")
                        .IsRequired();
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.ProductInventory", b =>
                {
                    b.Navigation("Product")
                        .IsRequired();
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.Session", b =>
                {
                    b.Navigation("Carts");
                });

            modelBuilder.Entity("Ecommerce.EFCoreApi.Domain.Entities.User", b =>
                {
                    b.Navigation("OrderDetails")
                        .IsRequired();

                    b.Navigation("Session")
                        .IsRequired();

                    b.Navigation("UserAddresses");

                    b.Navigation("UserPayments");
                });
#pragma warning restore 612, 618
        }
    }
}
