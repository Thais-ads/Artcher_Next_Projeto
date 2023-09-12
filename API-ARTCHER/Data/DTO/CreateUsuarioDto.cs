using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace API_ARTCHER.Data.DTO
{
    public class CreateUsuarioDto 
    {
        
       
        [Required(ErrorMessage = "Nome é obrigatorio!")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Email é obrigatorio!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Usuario é obrigatorio!")]
        public string Usuario { get; set; }


        [Required(ErrorMessage = "Senha é obrigatorio!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Confirmarsenha é obrigatorio!")]
        [Compare("Senha")]
        public string Confirmarsenha { get; set; }


        public DateTime Data { get; set; } = DateTime.Now;



       

    }
}
