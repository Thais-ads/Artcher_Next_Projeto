
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace API_ARTCHER.Models
{

    [Table("T_Cad_Usu")]
    public class CadUsuario
    {


        public CadUsuario(): base () { }


        [Key]
        [Column]
        [Display(Name = "Id_Usr")]
        public int Id_Usr { get; set; }


        [Column]
        [Display(Name = "Cpf")]
        public int Cpf { get; set; }


        //Estrangeira id
        //Estrangeiro Objeto
        //Estrangeiro exportando

        public virtual Login Login { get; set; }

        public virtual List<Postagem> Postagem { get; set; }

        public virtual UsuarioConvidado UsuarioConvidado { get; set; }


    }
}
