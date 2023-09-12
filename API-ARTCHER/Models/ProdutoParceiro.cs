
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace API_ARTCHER.Models
{

    [Table("T_Prod_Parc")]
    public class ProdutoParceiro  
    {


        public ProdutoParceiro(): base () { }


        [Key]
        [Column]
        [Display(Name = "Id_Prd")]
        public int Id_Prd { get; set; }

        [Column]
        [Display(Name = "Valor")]
        public int Valor { get; set; }

        [MaxLength(60)]
        [Column]
        [Display(Name = "Descricao")]
        public string Descricao { get; set; }

        [Column]
        [EmailAddress]
        [Display(Name = "Foto")]
        public string Foto { get; set; }

        [MaxLength(50)]
        [Column]
        [Display(Name = "Adicionais")]
        public string Adicionais { get; set; }

        [MaxLength(30)]
        [Column]
        [Display(Name = "Nome_Produto")]
        public string Nome_Produto { get; set; }


        //Estrangeira id
        //Estrangeiro Objeto
        //Estrangeiro exportando

        public virtual CadParceiro CadParceiro { get; set; }

        public virtual CardapioParceiros CardapioParceiros { get; set; }
    }
}
