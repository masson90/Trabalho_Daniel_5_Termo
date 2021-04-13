using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_Daniel_5_Termo.Models
{
    [Table("Marcas")]
    public class Marca
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Marca do Carro:")]
        public string NomeMarca { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Linha do Veículo:")]
        public string Linha { get; set; }

        [Required(ErrorMessage = "Data Obrigatorio")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Garantia")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Garantia { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Fabricação Nacionalidade:")]
        public string Nacionalidade { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Tempo de Mercado:")]
        public string TempoMercado { get; set; }

    }
}
