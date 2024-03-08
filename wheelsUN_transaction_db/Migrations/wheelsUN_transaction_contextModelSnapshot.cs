﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using wheelsUN_transaction_db.Data;

#nullable disable

namespace wheelsUN_transaction_db.Migrations
{
    [DbContext(typeof(wheelsUN_transaction_context))]
    partial class wheelsUN_transaction_contextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("wheelsUN_transaction_db.Data.CreditCard", b =>
                {
                    b.Property<int>("creditCardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("creditCardId"));

                    b.Property<string>("expirationDate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("number")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("securityCode")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("creditCardId");

                    b.ToTable("CreditCards");
                });

            modelBuilder.Entity("wheelsUN_transaction_db.Data.Transaction", b =>
                {
                    b.Property<int>("transactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("transactionId"));

                    b.Property<int>("creditCardId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("orderId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("paymentMethod")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("referenceCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("transactionIdPay")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("tripId")
                        .HasColumnType("int");

                    b.Property<int>("value")
                        .HasColumnType("int");

                    b.HasKey("transactionId");

                    b.HasIndex("creditCardId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("wheelsUN_transaction_db.Data.Transaction", b =>
                {
                    b.HasOne("wheelsUN_transaction_db.Data.CreditCard", "CreditCard")
                        .WithMany()
                        .HasForeignKey("creditCardId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CreditCard");
                });
#pragma warning restore 612, 618
        }
    }
}
