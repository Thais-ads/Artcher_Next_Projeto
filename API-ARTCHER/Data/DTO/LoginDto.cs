using System.ComponentModel.DataAnnotations;

namespace API_ARTCHER.Data.DTO
{
    public class LoginDto
    {

        [Required(ErrorMessage = "Email ou usuário é obrigatorio!")]
        public string EmailUser { get; set; }


        [Required(ErrorMessage = "Senha é obrigatorio!")]
        public string Senha { get; set; }
    }
}



