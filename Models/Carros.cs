using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_Daniel_5_Termo.Models
{
    [Table("Carros")]
    public class Carros
    {
        [Key]        
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Nome do Carro:")]
        public string NomeCarro { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Modelo Carro:")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Ano Obrigatorio")]
        [DataType(DataType.Date)]
        [Display(Name = "Ano de Fabricação")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Ano { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Cor do Carro:")]
        public string Cor { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Tipo de Combustível do Carro:")]
        public string Combustivel{ get; set; }
    }
}
