
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace API_ARTCHER.Models
{

    [Table("T_Card_Parc")]
    public class CardapioParceiros  
    {


        public CardapioParceiros(): base () { }


        [Key]
        [Column]
        [Display(Name = "Id_Card")]
        public int Id_Card { get; set; }

        [Column]
        [Display(Name = "Data")]
        public DateTime Data { get; set; }

        [MaxLength(100)]
        [Column]
        [Display(Name = "Cardapio")]
        public string Cardapio { get; set; }

        [Column]
        [Display(Name = "Valores")]
        public int Valores { get; set; }

        [MaxLength(100)]
        [Column]
        [Display(Name = "Descricao_Extra")]
        public string Descricao_Extra { get; set; }

        //Estrangeira id
        [ForeignKey("ProdutoParceiroId")]
        [Column("T_PROD_PARC_id_prd")]
        public int? ProdutoParceiroId { get; set; }


        //Estrangeiro Objeto

        public ProdutoParceiro ProdutoParceiro { get; set; }

        //Estrangeiro exportando
















    }
}
