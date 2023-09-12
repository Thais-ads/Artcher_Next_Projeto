
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace API_ARTCHER.Models
{

    [Table("Usuario")]
    public class CadastroUsuario  
    {


        public CadastroUsuario (): base () { }


        [Key]
        [Column]
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        [MaxLength(30)]
        [Column]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [MaxLength(30)]
        [Column]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [MaxLength(30)]
        [Column]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [MaxLength(30)]
        [Column]
        [Display(Name = "Usuario")]
        public string Usuario { get; set; }


        [Column]
        [Display(Name = "DataAlteracao")]
        public DateTime Data { get; set; }


       




    }
}
