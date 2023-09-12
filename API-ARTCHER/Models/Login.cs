
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace API_ARTCHER.Models
{

    [Table("T_Log")]
    public class Login  
    {


        public Login(): base () { }


        [Key]
        [Column]
        [Display(Name = "Id_Log")]
        public int Id_Log { get; set; }

        [MaxLength(40)]
        [Column]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [MaxLength(30)]
        [Column]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [MaxLength(30)]
        [Column]
        [EmailAddress]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        
        [Column]
        [Display(Name = "Telefone")]
        public int Telefone { get; set; }

        [Column]
        [Display(Name = "Foto")]
        public string Foto { get; set; }

     


        //Estrangeira id

        [ForeignKey("CadParceiroID")]
        [Column("t_cad_parc_id_parc")]

        public int? CadParceiroID { get; set; }

        [ForeignKey("EnderecoId")]
        [Column("t_end_id_end")]
        public int? EnderecoId { get; set; }

        [ForeignKey("RedeSocialId")]
        [Column("t_rede_soc_id_feed")]
        public int? RedeSocialId { get; set; }

        [ForeignKey("CadUsuarioId")]
        [Column("t_cad_usu_id_usr")]
        public int? CadUsuarioId { get; set; }


        //Estrangeiro Objeto

        public CadParceiro CadParceiro { get; set; }

        public Endereco Endereco { get; set; }

        public RedeSocial RedeSocial { get; set; }

        public CadUsuario CadUsuario { get; set; }



        //Estrangeiro exportando





    }
}
