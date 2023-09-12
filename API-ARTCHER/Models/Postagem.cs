
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace API_ARTCHER.Models
{

    [Table("T_PST")]
    public class Postagem  
    {


        public Postagem(): base () { }


        [Key]
        [Column]
        [Display(Name = "Id_Pst")]
        public int Id_Pst { get; set; }

 
        [Column]
        [Display(Name = "Avaliacao")]
        public int Avaliacao { get; set; }


        [MaxLength(30)]
        [Column]
        [Display(Name = "Indicacao")]
        public string Indicacao { get; set; }

        [Column]
        [Display(Name = "Data")]
        public DateTime Data { get; set; }


        //Estrangeira id

        [ForeignKey("CadUsuarioId")]
        [Column("t_cad_usu_id_usr")]
        public int? CadUsuarioId { get; set; }

        //Estrangeiro Objeto

        public CadUsuario CadUsuario { get; set; }


        //Estrangeiro exportando




    }
}
