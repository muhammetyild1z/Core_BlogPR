﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220817172023_comment")]
    partial class comment
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.About", b =>
                {
                    b.Property<int>("aboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("aboutDetails_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutDetails_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutImage_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutImage_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutMapLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("aboutStatus")
                        .HasColumnType("bit");

                    b.HasKey("aboutID");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.Property<int>("blogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommentID")
                        .HasColumnType("int");

                    b.Property<string>("blogContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("blogCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("blogSmallImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("blogStatus")
                        .HasColumnType("bit");

                    b.Property<string>("blogThumbnailImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("blogTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("catagoryID")
                        .HasColumnType("int");

                    b.Property<int>("writerID")
                        .HasColumnType("int");

                    b.HasKey("blogID");

                    b.HasIndex("CommentID");

                    b.HasIndex("catagoryID");

                    b.HasIndex("writerID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Catagory", b =>
                {
                    b.Property<int>("catagoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("catagoryDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("catagoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("catagoryStatus")
                        .HasColumnType("bit");

                    b.HasKey("catagoryID");

                    b.ToTable("Catagoies");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.Property<int>("commentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("blogID")
                        .HasColumnType("int");

                    b.Property<string>("commentContect")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("commentDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("commentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("commentTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("commentUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("commentID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("contactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("contactBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("contactDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("contactMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("contactStatus")
                        .HasColumnType("bit");

                    b.Property<string>("contactUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("contactID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.NewsLatter", b =>
                {
                    b.Property<int>("mailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("mailStatus")
                        .HasColumnType("bit");

                    b.HasKey("mailID");

                    b.ToTable("NewsLatters");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Writer", b =>
                {
                    b.Property<int>("writerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("writerAbout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("writerImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("writerMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("writerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("writerPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("writerStatus")
                        .HasColumnType("bit");

                    b.HasKey("writerID");

                    b.ToTable("Writers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Comment", "comment")
                        .WithMany("Blogs")
                        .HasForeignKey("CommentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Catagory", "Catagory")
                        .WithMany("Blogs")
                        .HasForeignKey("catagoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Writer", "Writer")
                        .WithMany("Blogs")
                        .HasForeignKey("writerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Catagory");

                    b.Navigation("comment");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Catagory", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Writer", b =>
                {
                    b.Navigation("Blogs");
                });
#pragma warning restore 612, 618
        }
    }
}