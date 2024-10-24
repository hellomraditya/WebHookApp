﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebHookApp;

#nullable disable

namespace WebHookApp.Migrations
{
    [DbContext(typeof(webHookDataContext))]
    [Migration("20241024051027_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("WebHookApp.Models.WebHookRequestModel", b =>
                {
                    b.Property<int>("requestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("requestId"));

                    b.Property<string>("body")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("headers")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ipAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("method")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("path")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("queryParams")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("timeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("urlId")
                        .HasColumnType("char(36)");

                    b.Property<string>("userAgent")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("requestId");

                    b.HasIndex("urlId");

                    b.ToTable("requests");
                });

            modelBuilder.Entity("WebHookApp.Models.WebHookUrl", b =>
                {
                    b.Property<Guid>("urlId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("generatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("urlId");

                    b.ToTable("Urls");
                });

            modelBuilder.Entity("WebHookApp.Models.WebHookRequestModel", b =>
                {
                    b.HasOne("WebHookApp.Models.WebHookUrl", "url")
                        .WithMany("requests")
                        .HasForeignKey("urlId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("url");
                });

            modelBuilder.Entity("WebHookApp.Models.WebHookUrl", b =>
                {
                    b.Navigation("requests");
                });
#pragma warning restore 612, 618
        }
    }
}
