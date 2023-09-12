using Microsoft.EntityFrameworkCore;
using API_ARTCHER.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_ARTCHER.Data.Map
{
    public class PostagemMap : IEntityTypeConfiguration<Postagem>
    {
        public void Configure(EntityTypeBuilder<Postagem> builder)
        {
            builder.ToTable("T_PST");
            builder.HasKey(x => x.Id_Pst);

            builder.HasOne(x => x.CadUsuario)
                .WithMany(x => x.Postagem)
                .HasForeignKey(x => x.CadUsuarioId);
        }
    }
}
