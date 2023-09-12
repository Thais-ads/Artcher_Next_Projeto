using Microsoft.EntityFrameworkCore;
using API_ARTCHER.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_ARTCHER.Data.Map
{

    public class CardapioParceiroMap : IEntityTypeConfiguration<CardapioParceiros>
    {
        public void Configure(EntityTypeBuilder<CardapioParceiros> builder)
        {
            builder.ToTable("T_Card_Parc");
            builder.HasKey(x => x.Id_Card);

            builder.HasOne(x => x.ProdutoParceiro)
                .WithOne()
                .HasForeignKey<CardapioParceiros>(x => x.ProdutoParceiroId)
                .HasPrincipalKey<ProdutoParceiro>(x => x.Id_Prd);
        }
    }

}
