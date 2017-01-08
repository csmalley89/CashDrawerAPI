using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CashDrawer.Data;

namespace CashDrawerAPI.Migrations
{
    [DbContext(typeof(CashDrawerContext))]
    partial class CashDrawerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("CashDrawer.Models.Ledger", b =>
                {
                    b.Property<int>("LedgerId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("ClosedDrawerBalance");

                    b.Property<decimal>("OpenDrawerBalance");

                    b.Property<DateTimeOffset>("TimeStamp")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasDefaultValueSql("strftime('%Y-%m-%d %H:%M:%S', 'now', 'localtime')");

                    b.HasKey("LedgerId");

                    b.ToTable("Ledger");
                });

            modelBuilder.Entity("CashDrawer.Models.LineItem", b =>
                {
                    b.Property<int>("LineItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("LineItemId");

                    b.ToTable("LineItem");
                });

            modelBuilder.Entity("CashDrawer.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("SubTotal");

                    b.Property<decimal?>("Tax");

                    b.Property<DateTimeOffset>("TimeStamp")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasDefaultValueSql("strftime('%Y-%m-%d %H:%M:%S', 'now', 'localtime')");

                    b.HasKey("OrderId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("CashDrawer.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Cost");

                    b.Property<bool>("IsTaxable");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("TaxRate");

                    b.HasKey("ProductId");

                    b.ToTable("Product");
                });
        }
    }
}
