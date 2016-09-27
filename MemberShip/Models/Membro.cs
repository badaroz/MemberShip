using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace MemberShip.Models
{
    [TableName("Membros")]
    public class Membro
    {
        [Key]
        public int MembroId { get; set; }

        public string Nome { get; set; }

        public Membro conjuje { get; set; }

        public int ConjujeId { get; set; }

        public virtual ICollection<Membro> Familia { get; set; }
          
    }
}