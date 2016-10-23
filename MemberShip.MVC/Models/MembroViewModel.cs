using AutoMapper;
using MemberShip.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemberShip.MVC.Models
{
    public class MembroViewModel
    {
        [Key]
        public int MembroId { get; set; }

        public string Nome { get; set; }

        [Display(Name = "Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DataEntradada { get; set; }
        
        public int TipoEntrada { get; set; }  
        
        public List<SelectListItem> Entrada { get; set; }    

    }
}