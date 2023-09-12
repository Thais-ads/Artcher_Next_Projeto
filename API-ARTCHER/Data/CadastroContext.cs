using API_ARTCHER.Data.Map;
using API_ARTCHER.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace API_ARTCHER.Data
{
    public class CadastroContext : IdentityDbContext
    {

        public CadastroContext (DbContextOptions<CadastroContext> options)
            :base (options)
        {

        }

        public DbSet<CadastroUsuario> CadastroDeUsuarios { get; set; }
        public DbSet<CadastroFilial> CadastroFilials { get; set; }


        public DbSet<CadParceiro> CadParceiro { get; set; }
        public DbSet<CadUsuario> CadUsuario { get; set; }
        public DbSet<CardapioParceiros> CardapioParceiros { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Postagem> Postagem { get; set; }
        public DbSet<ProdutoParceiro> ProdutoParceiro { get; set; }
        public DbSet<RedeSocial> RedeSocial { get; set; }
        public DbSet<UsuarioConvidado> UsuarioConvidado { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new CadParceiroMap());
            modelBuilder.ApplyConfiguration(new CadUsuarioMap());
            modelBuilder.ApplyConfiguration(new CardapioParceiroMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new LoginMap());
            modelBuilder.ApplyConfiguration(new PostagemMap());
            modelBuilder.ApplyConfiguration(new UsuarioConvidadoMap());

            base.OnModelCreating(modelBuilder);
        }

    }

}
