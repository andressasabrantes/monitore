namespace Data.Configurations.Application
{
    public class MetaFinanceiraConfiguration : IEntityTypeConfiguration<MetaFinanceira>
    {
        public void Configure(EntityTypeBuilder<MetaFinanceira> builder)
        {
            builder.ToTable("metafinanceira");

            builder.HasKey(x => x.Id).HasName("pk_metafinanceira");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Titulo).HasColumnName("titulo");
            builder.Property(x => x.Descricao).HasColumnName("descricao");
            builder.Property(x => x.ValorMeta).HasColumnName("valorMeta");
        }
    }
}
