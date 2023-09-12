using Microsoft.EntityFrameworkCore;
using API_ARTCHER.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_ARTCHER.Data.Map
{
    public class CadParceiroMap : IEntityTypeConfiguration<CadParceiro>
    {
        public void Configure(EntityTypeBuilder<CadParceiro> builder)
        {
            builder.ToTable("T_Cad_Parc");
            builder.HasKey(x => x.Id_Parc);

            builder.HasOne(x => x.CardapioParceiros)
                .WithOne()
                .HasForeignKey<CadParceiro>(x => x.CardapioParceirosId)
                .HasPrincipalKey<CardapioParceiros>(x => x.Id_Card);

            builder.HasOne(x => x.ProdutoParceiro)
                .WithOne()
                .HasForeignKey<CadParceiro>(x => x.ProdutoParceiroId)
                .HasPrincipalKey<ProdutoParceiro>(x => x.Id_Prd);





        }
    }
}
