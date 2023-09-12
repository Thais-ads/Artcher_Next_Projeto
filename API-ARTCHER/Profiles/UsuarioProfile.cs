using API_ARTCHER.Data.DTO;
using API_ARTCHER.Models;
using AutoMapper;

namespace API_ARTCHER.Profiles
{


    public class UsuarioProfile : Profile

    {
        public UsuarioProfile ()
        {

            CreateMap <CreateUsuarioDto , CadastroUsuario>();
        }

    }
}
