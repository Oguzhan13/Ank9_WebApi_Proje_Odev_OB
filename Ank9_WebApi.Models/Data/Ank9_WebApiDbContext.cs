using Ank9_WebApi.Models.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank9_WebApi.Models.Data
{
    public class Ank9_WebApiDbContext : DbContext
    {
        public Ank9_WebApiDbContext(DbContextOptions<Ank9_WebApiDbContext>options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new KisilerConfiguration());

            #region Seed data            
            modelBuilder.Entity<Kisiler>().HasData(
                new Kisiler { KisiId = 1, TCKimlik=12345, Ad = "Ali", Soyad = "Yılmaz", DogumTarihi = DateTime.Parse("2000/5/4"), Cinsiyet = CinsiyetTipi.E },
                new Kisiler { KisiId = 2, TCKimlik = 12346, Ad = "Burak", Soyad = "Yılmaz", DogumTarihi = DateTime.Parse("1994/9/16"), Cinsiyet = CinsiyetTipi.E },
                new Kisiler { KisiId = 3, TCKimlik = 12347, Ad = "Canan", Soyad = "Şaşmaz", DogumTarihi = DateTime.Parse("1991/9/8"), Cinsiyet = CinsiyetTipi.K },
                new Kisiler { KisiId = 4, TCKimlik = 12348, Ad = "Derya", Soyad = "Demet", DogumTarihi = DateTime.Parse("2001/10/24"), Cinsiyet = CinsiyetTipi.K },
                new Kisiler { KisiId = 5, TCKimlik = 12349, Ad = "Erdi", Soyad = "Yaman", DogumTarihi = DateTime.Parse("1997/3/21"), Cinsiyet = CinsiyetTipi.E }
                );
            #endregion
        }

        public DbSet<Kisiler> Kisiler { get; set; }
    }
}
