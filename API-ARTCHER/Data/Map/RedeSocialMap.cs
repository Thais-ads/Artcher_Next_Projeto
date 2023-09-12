using Microsoft.EntityFrameworkCore;
using API_ARTCHER.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_ARTCHER.Data.Map
{
    public class RedeSocialMap : IEntityTypeConfiguration<RedeSocial>
    {
        public void Configure(EntityTypeBuilder<RedeSocial> builder)
        {
            builder.ToTable("T_Rede_Soc");
            builder.HasKey(x => x.Id_Feed);

        }
    }
}
