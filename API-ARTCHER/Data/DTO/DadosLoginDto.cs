using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_ARTCHER.Data.DTO
{
    public class DadosLoginDto
    {


        [Required(ErrorMessage = "Email é obrigatorio!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é obrigatorio!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Nome é obrigatorio!")]
        public string Nome { get; set; }

        public int Telefone { get; set; }

        public string Foto { get; set; }
    }
}



