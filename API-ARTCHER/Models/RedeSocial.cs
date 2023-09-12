
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace API_ARTCHER.Models
{

    [Table("T_Rede_Soc")]
    public class RedeSocial  
    {


        public RedeSocial(): base () { }


        [Key]
        [Column]
        [Display(Name = "Id_Feed")]
        public int Id_Feed { get; set; }

 
        [Column]
        [Display(Name = "Curtida")]
        public int Curtida { get; set; }

        [Column]
        [Display(Name = "Foto_Postagem")]
        public string Foto_Postagem { get; set; }

        [MaxLength(50)]
        [Column]
        [Display(Name = "Comentario")]
        public string Comentario { get; set; }



        //Estrangeira id
        //Estrangeiro Objeto
        //Estrangeiro exportando

        public virtual Login Login { get; set; }


    }
}
