using Microsoft.EntityFrameworkCore;
using API_ARTCHER.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_ARTCHER.Data.Map
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("T_End");
            builder.HasKey(x => x.Id_End);

            builder.HasOne(x => x.Login)
                .WithOne(x => x.Endereco)
                .HasForeignKey<Endereco>(x => x.Id_End)
                .HasPrincipalKey<Login>(x => x.EnderecoId);

            builder.HasOne(x => x.UsuarioConvidado)
                .WithOne(x => x.Endereco)
                .HasForeignKey<Endereco>(x => x.Id_End)
                .HasPrincipalKey<UsuarioConvidado>(x => x.EnderecoId);
        }
    }
}
