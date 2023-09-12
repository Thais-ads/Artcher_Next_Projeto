using Microsoft.EntityFrameworkCore;
using API_ARTCHER.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_ARTCHER.Data.Map
{
    public class CadUsuarioMap : IEntityTypeConfiguration<CadUsuario>
    {
        public void Configure(EntityTypeBuilder<CadUsuario> builder)
        {
            builder.ToTable("T_Cad_Usu");
            builder.HasKey(x => x.Id_Usr);
        }
    }
}
