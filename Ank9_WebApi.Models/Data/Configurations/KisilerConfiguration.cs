using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank9_WebApi.Models.Data.Configurations
{
    public class KisilerConfiguration : IEntityTypeConfiguration<Kisiler>
    {
        public void Configure(EntityTypeBuilder<Kisiler> builder)
        {
            #region Property builder
            builder.Property(x => x.KisiId).IsRequired().UseIdentityColumn();
            builder.Property(x => x.TCKimlik);      //son beş rakam kontrolü TODO
            builder.Property(x => x.Ad).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Soyad).IsRequired().HasMaxLength(50);   //Büyük Harf kontrolü TODO
            builder.Property(x => x.DogumTarihi).IsRequired();      //20 yaş kontrolü TODO
            builder.Property(x => x.Cinsiyet).IsRequired();
            #endregion

            #region Class builder
            builder.HasKey(x => x.KisiId);            
            #endregion
        }
    }

}
