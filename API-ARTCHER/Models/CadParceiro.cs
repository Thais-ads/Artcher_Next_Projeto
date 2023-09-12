
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace API_ARTCHER.Models
{

    [Table("T_Cad_Parc")]
    public class CadParceiro

    { 
        public CadParceiro(): base () { }


        [Key]
        [Column]
        [Display(Name = "Id_Parc")]
        public int Id_Parc { get; set; }

        [Column]
        [Display(Name = "Cnpj")]
        public int Cnpj { get; set; }

        [MaxLength(50)]
        [Column]
        [Display(Name = "Tipo_Especialidade")]
        public string Tipo_Especialidade { get; set; }

        [MaxLength(50)]
        [Column]
        [Display(Name = "Servicos")]
        public string Servicos { get; set; }

        [Column]
        [Display(Name = "Valor_Medio")]
        public int Valor_Medio { get; set; }

        [MaxLength(500)]
        [Column]
        [Display(Name = "Descricao")]
        public string Descricao { get; set; }


        //Estrangeira id
        [ForeignKey("CardapioParceirosId")]
        [Column("t_card_parc_id_card")]
        public int? CardapioParceirosId { get; set; }

        [ForeignKey("ProdutoParceiroId")]
        [Column("t_card_parc_T_PROD_PARC_id_prd")]
        public int? ProdutoParceiroId { get; set; }

        //Estrangeiro Objeto

        public CardapioParceiros CardapioParceiros { get; set; }

        public ProdutoParceiro ProdutoParceiro { get; set; }

        //Estrangeiro exportando


        public virtual Login Login { get; set; }


    }
}
