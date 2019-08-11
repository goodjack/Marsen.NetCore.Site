﻿// <auto-generated />
using Marsen.NetCore.DA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Marsen.NetCore.DA.Migrations
{
    [DbContext(typeof(MARSContext))]
    partial class MARSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Marsen.NetCore.DA.Models.Member", b =>
                {
                    b.Property<long>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MemberAccount")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("MemberName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("MemberId");

                    b.HasIndex("MemberId")
                        .IsUnique()
                        .HasName("IX_MemberAccount");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("Marsen.NetCore.DA.Models.Product", b =>
                {
                    b.Property<long>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Product_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductInformation")
                        .HasColumnName("Product_Information")
                        .HasMaxLength(1000);

                    b.Property<string>("ProductName")
                        .HasColumnName("Product_Name")
                        .HasMaxLength(100);

                    b.Property<string>("ProductPicture")
                        .HasColumnName("Product_Picture")
                        .HasMaxLength(200);

                    b.Property<string>("ProductSpec")
                        .HasColumnName("Product_Spec")
                        .HasMaxLength(1000);

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
