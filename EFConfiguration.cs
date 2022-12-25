    
namespace Municipios {
    internal class MunicipioConfiguracao : IEntityTypeConfiguration<Municipio>
    {
        public void Configure(EntityTypeBuilder<Municipio> builder)
        {
            builder.ToTable("Municipios");
            builder.HasKey(x => x.IdMunicipio);
            builder.Property(x => x.IdMunicipio).ValueGeneratedNever();
            builder.Property(x => x.Nome).HasColumnType("varchar(32)");
            builder.HasOne(x => x.UF).WithMany(x => x.Municipios).HasForeignKey(x => x.IdUF);

            builder.HasIndex(i => i.Nome);
        }
    }

    internal class UFConfiguracao : IEntityTypeConfiguration<UF>
    {
        public void Configure(EntityTypeBuilder<UF> builder)
        {
            builder.ToTable("UFs");
            builder.HasKey(x => x.IdUF);
            builder.Property(x => x.IdUF).ValueGeneratedNever();
            builder.Property(x => x.Sigla).HasColumnType("varchar(2)");
            builder.Property(x => x.Nome).HasColumnType("varchar(19)");

            builder.HasIndex(i => i.Sigla);
        }
    }
}
