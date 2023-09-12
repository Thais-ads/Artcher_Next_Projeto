using Microsoft.EntityFrameworkCore;
using API_ARTCHER.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_ARTCHER.Data.Map
{
    public class ProdutoParceiroMap : IEntityTypeConfiguration<ProdutoParceiro>
    {
        public void Configure(EntityTypeBuilder<ProdutoParceiro> builder)
        {
            builder.ToTable("T_Prod_Parc");
            builder.HasKey(x => x.Id_Prd);

        }
    }
}
