using Microsoft.EntityFrameworkCore;
using API_ARTCHER.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_ARTCHER.Data.Map
{
    public class LoginMap : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.ToTable("T_Log");
            builder.HasKey(x => x.Id_Log);

            builder.HasOne(x => x.CadParceiro)
                .WithOne()
                .HasForeignKey<Login>(x => x.CadUsuarioId)
                .HasPrincipalKey<CadParceiro>(x => x.Id_Parc);

            builder.HasOne(x => x.Endereco)
                .WithOne()
                .HasForeignKey<Login>(x => x.EnderecoId)
                .HasPrincipalKey<Endereco>(x => x.Id_End);

            builder.HasOne(x => x.RedeSocial)
                .WithOne()
                .HasForeignKey<Login>(x => x.RedeSocialId)
                .HasPrincipalKey<RedeSocial>(x => x.Id_Feed);

            builder.HasOne(x => x.CadUsuario)
                .WithOne()
                .HasForeignKey<Login>(x => x.CadUsuarioId)
                .HasPrincipalKey<CadUsuario>(x => x.Id_Usr);
        }
    }
}
