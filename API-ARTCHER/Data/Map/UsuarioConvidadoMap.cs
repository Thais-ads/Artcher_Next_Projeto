using Microsoft.EntityFrameworkCore;
using API_ARTCHER.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_ARTCHER.Data.Map
{
    public class UsuarioConvidadoMap : IEntityTypeConfiguration<UsuarioConvidado>
    {
        public void Configure(EntityTypeBuilder<UsuarioConvidado> builder)
        {
            builder.ToTable("T_USU_CONV");
            builder.HasKey(x => x.Id_ind);

            builder.HasOne(x => x.CadUsuario)
                .WithOne()
                .HasForeignKey<UsuarioConvidado>(x => x.CadUsuarioId)
                .HasPrincipalKey<CadUsuario>(x => x.Id_Usr);

            builder.HasOne(x => x.Endereco)
                .WithOne()
                .HasForeignKey<UsuarioConvidado>(x => x.EnderecoId)
                .HasPrincipalKey<Endereco>(x => x.Id_End);
        }
    }

}
