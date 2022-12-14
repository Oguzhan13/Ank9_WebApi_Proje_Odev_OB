// <auto-generated />
using System;
using Ank9_WebApi.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ank9_WebApi.Models.Migrations
{
    [DbContext(typeof(Ank9_WebApiDbContext))]
    partial class Ank9_WebApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Ank9_WebApi.Models.Kisiler", b =>
                {
                    b.Property<int>("KisiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KisiId"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Cinsiyet")
                        .HasColumnType("int");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TCKimlik")
                        .HasColumnType("int");

                    b.HasKey("KisiId");

                    b.ToTable("Kisiler");

                    b.HasData(
                        new
                        {
                            KisiId = 1,
                            Ad = "Ali",
                            Cinsiyet = 0,
                            DogumTarihi = new DateTime(2000, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Soyad = "Yılmaz",
                            TCKimlik = 12345
                        },
                        new
                        {
                            KisiId = 2,
                            Ad = "Burak",
                            Cinsiyet = 0,
                            DogumTarihi = new DateTime(1994, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Soyad = "Yılmaz",
                            TCKimlik = 12346
                        },
                        new
                        {
                            KisiId = 3,
                            Ad = "Canan",
                            Cinsiyet = 1,
                            DogumTarihi = new DateTime(1991, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Soyad = "Şaşmaz",
                            TCKimlik = 12347
                        },
                        new
                        {
                            KisiId = 4,
                            Ad = "Derya",
                            Cinsiyet = 1,
                            DogumTarihi = new DateTime(2001, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Soyad = "Demet",
                            TCKimlik = 12348
                        },
                        new
                        {
                            KisiId = 5,
                            Ad = "Erdi",
                            Cinsiyet = 0,
                            DogumTarihi = new DateTime(1997, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Soyad = "Yaman",
                            TCKimlik = 12349
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
