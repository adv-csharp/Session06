using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session06.DataModel.config
{
    public class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder
                .ToTable("Shahr")
                .Property(x => x.Name)
                    .HasMaxLength(50)
                    .IsUnicode(true)
                    .HasComment("نام");
            builder.Property(x => x.Id)
                .HasComment("شناسه");
        }
    }
}
