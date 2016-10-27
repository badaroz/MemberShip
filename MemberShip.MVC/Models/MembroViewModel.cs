using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using static MemberShip.Domain.Enums.EnumsMembros;

namespace MemberShip.MVC.Models
{
    public class MembroViewModel
    {
        [Key]
        public int MembroId { get; set; }
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string Nome { get; set; }

        [Display(Name = "Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DataEntradada { get; set; }
        
        public TipoEntradaEnum TipoEntrada { get; set; }

        public SexoEnum Sexo { get; set; }
        
       // public List<SelectListItem> Entrada { get; set; }
        //public List<SelectListItem> Sexos { get; set; }

    }
}