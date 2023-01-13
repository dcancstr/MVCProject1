﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230111131542_SecondMigration")]
    partial class SecondMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Blog", b =>
                {
                    b.Property<int>("BlogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BlogID"));

                    b.Property<string>("BlogContent")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("BlogCreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("BlogImage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("BlogStatus")
                        .HasColumnType("boolean");

                    b.Property<string>("BlogThumbnailImage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("BlogTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("BlogID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("EntityLayer.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CommentID"));

                    b.Property<string>("CommentContet")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("CommentStatus")
                        .HasColumnType("boolean");

                    b.Property<string>("CommentTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CommentUserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CommentID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.About", b =>
                {
                    b.Property<int>("AboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AboutID"));

                    b.Property<string>("AboutDetails1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AboutDetails2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AboutImgae1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AboutImgae2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AboutMapLocation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("AboutStatus")
                        .HasColumnType("boolean");

                    b.HasKey("AboutID");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CategoryDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("CategoryStatus")
                        .HasColumnType("boolean");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ContactID"));

                    b.Property<DateTime>("ContactDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ContactMail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ContactMessage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("ContactStatus")
                        .HasColumnType("boolean");

                    b.Property<string>("ContactSubject")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ContactUserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ContactID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Writer", b =>
                {
                    b.Property<int>("WriterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("WriterID"));

                    b.Property<string>("WriterAbout")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WriterImage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WriterMail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WriterName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WriterPassword")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("WriterStatus")
                        .HasColumnType("boolean");

                    b.HasKey("WriterID");

                    b.ToTable("Writers");
                });
#pragma warning restore 612, 618
        }
    }
}