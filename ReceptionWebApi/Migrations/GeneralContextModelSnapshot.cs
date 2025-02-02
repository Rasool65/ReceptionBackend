﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReceptionWebApi.DataContext;

#nullable disable

namespace ReceptionWebApi.Migrations
{
    [DbContext(typeof(GeneralContext))]
    partial class GeneralContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ReceptionWebApi.DataContext.Models.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodId"));

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FoodName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.HasKey("FoodId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("ReceptionWebApi.DataContext.Models.FoodOrder", b =>
                {
                    b.Property<int>("FoodOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodOrderId"));

                    b.Property<int?>("FoodId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("FoodOrderId");

                    b.HasIndex("FoodId");

                    b.HasIndex("OrderId");

                    b.ToTable("FoodOrders");
                });

            modelBuilder.Entity("ReceptionWebApi.DataContext.Models.Gift", b =>
                {
                    b.Property<int>("GiftId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GiftId"));

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GiftName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.HasKey("GiftId");

                    b.ToTable("Gifts");
                });

            modelBuilder.Entity("ReceptionWebApi.DataContext.Models.GiftOrder", b =>
                {
                    b.Property<int>("GiftOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GiftOrderId"));

                    b.Property<int?>("GiftId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("GiftOrderId");

                    b.HasIndex("GiftId");

                    b.HasIndex("OrderId");

                    b.ToTable("GiftOrders");
                });

            modelBuilder.Entity("ReceptionWebApi.DataContext.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FoodId")
                        .HasColumnType("int");

                    b.Property<int?>("GiftId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<bool>("VipStatus")
                        .HasColumnType("bit");

                    b.HasKey("OrderId");

                    b.HasIndex("FoodId");

                    b.HasIndex("GiftId");

                    b.HasIndex("RoleId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ReceptionWebApi.DataContext.Models.ReceptionPlace", b =>
                {
                    b.Property<int>("ReceptionPlaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReceptionPlaceId"));

                    b.Property<string>("Activity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AreaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("ReceptionPlaceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomNo")
                        .HasColumnType("int");

                    b.HasKey("ReceptionPlaceId");

                    b.HasIndex("OrderId");

                    b.ToTable("ReceptionPlaces");
                });

            modelBuilder.Entity("ReceptionWebApi.DataContext.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ReceptionWebApi.DataContext.Models.RoleOrder", b =>
                {
                    b.Property<int>("RoleOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleOrderId"));

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("RoleOrderId");

                    b.HasIndex("OrderId");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleOrders");
                });

            modelBuilder.Entity("ReceptionWebApi.DataContext.Models.FoodOrder", b =>
                {
                    b.HasOne("ReceptionWebApi.DataContext.Models.Food", "Food")
                        .WithMany("FoodOrders")
                        .HasForeignKey("FoodId");

                    b.HasOne("ReceptionWebApi.DataContext.Models.Order", "Order")
                        .WithMany("FoodOrders")
                        .HasForeignKey("OrderId");

                    b.Navigation("Food");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("ReceptionWebApi.DataContext.Models.GiftOrder", b =>
                {
                    b.HasOne("ReceptionWebApi.DataContext.Models.Gift", "Gift")
                        .WithMany("GiftOrders")
                        .HasForeignKey("GiftId");

                    b.HasOne("ReceptionWebApi.DataContext.Models.Order", "Order")
                        .WithMany("GiftOrders")
                        .HasForeignKey("OrderId");

                    b.Navigation("Gift");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("ReceptionWebApi.DataContext.Models.Order", b =>
                {
                    b.HasOne("ReceptionWebApi.DataContext.Models.Food", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId");

                    b.HasOne("ReceptionWebApi.DataContext.Models.Gift", "Gift")
                        .WithMany()
                        .HasForeignKey("GiftId");

                    b.HasOne("ReceptionWebApi.DataContext.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Food");

                    b.Navigation("Gift");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ReceptionWebApi.DataContext.Models.ReceptionPlace", b =>
                {
                    b.HasOne("ReceptionWebApi.DataContext.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("ReceptionWebApi.DataContext.Models.RoleOrder", b =>
                {
                    b.HasOne("ReceptionWebApi.DataContext.Models.Order", "Order")
                        .WithMany("RoleOrders")
                        .HasForeignKey("OrderId");

                    b.HasOne("ReceptionWebApi.DataContext.Models.Role", "Role")
                        .WithMany("RoleOrders")
                        .HasForeignKey("RoleId");

                    b.Navigation("Order");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ReceptionWebApi.DataContext.Models.Food", b =>
                {
                    b.Navigation("FoodOrders");
                });

            modelBuilder.Entity("ReceptionWebApi.DataContext.Models.Gift", b =>
                {
                    b.Navigation("GiftOrders");
                });

            modelBuilder.Entity("ReceptionWebApi.DataContext.Models.Order", b =>
                {
                    b.Navigation("FoodOrders");

                    b.Navigation("GiftOrders");

                    b.Navigation("RoleOrders");
                });

            modelBuilder.Entity("ReceptionWebApi.DataContext.Models.Role", b =>
                {
                    b.Navigation("RoleOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
