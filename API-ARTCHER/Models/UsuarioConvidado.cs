
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace API_ARTCHER.Models
{

    [Table("T_USU_CONV")]
    public class UsuarioConvidado  
    {


        public UsuarioConvidado(): base () { }


        [Key]
        [Column]
        [Display(Name = "Id_Ind")]
        public int Id_ind { get; set; }

        [Column]
        [Display(Name = "Data")]
        public DateTime Data { get; set; }

        [MaxLength(80)]
        [Column]
        [Display(Name = "Observacoes")]
        public string Observacoes { get; set; }


        [Column]
        [Display(Name = "Qt_pessoas")]
        public int Qt_Pessoas { get; set; }

        //Estrangeira id

        [ForeignKey("CadUsuarioId")]
        [Column("t_cad_usu_id_usr")]
        public int? CadUsuarioId { get; set; }

        [ForeignKey("EnderecoId")]
        [Column("t_end_id_end")]
        public int? EnderecoId { get; set; }

        //Estrangeiro Objeto

        public CadUsuario CadUsuario { get; set; }

        public Endereco Endereco { get; set; }


        //Estrangeiro exportando





    }
}
