
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace API_ARTCHER.Models
{

    [Table("T_End")]
    public class Endereco  
    {


        public Endereco(): base () { }


        [Key]
        [Column]
        [Display(Name = "Id_End")]
        public int Id_End { get; set; }

        [MaxLength(50)]
        [Column]
        [Display(Name = "logradouro")]
        public string logradouro { get; set; }

        [MaxLength(2)]
        [Column]
        [Display(Name = "Uf")]
        public string Uf { get; set; }

        [Column]
        [EmailAddress]
        [Display(Name = "Cep")]
        public int Cep { get; set; }

        
        [Column]
        [Display(Name = "Numero")]
        public int Numero { get; set; }

        [MaxLength(50)]
        [Column]
        [Display(Name = "Complemento")]
        public string Foto { get; set; }


        //Estrangeira id
        //Estrangeiro Objeto
        //Estrangeiro exportando

        public virtual Login Login { get; set; }

        public virtual UsuarioConvidado UsuarioConvidado { get; set; }



    }


}
