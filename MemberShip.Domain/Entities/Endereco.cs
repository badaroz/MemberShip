using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberShip.Domain.Entities
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }

        public virtual Membro mebro { get; set; }
        public int? MembroId { get; set; }

        public virtual Familia familia{get;set;}
        public int? FamiliaId { get; set; }

    }
}
